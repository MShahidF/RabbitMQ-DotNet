using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ_Producer.Models;
using Microsoft.Extensions.Options;

namespace RabbitMQ_Producer.RabbitMQ
{
  public class MessageProducer : IMessageProducer
  {
    private IConnection _connection;
    private readonly RabbitMQSettings _rabbitMQSettings;

    public MessageProducer(IOptions<RabbitMQSettings> options)
    {
      _rabbitMQSettings = options.Value;
    }

    public void SendMessage<T>(T message)
    {
      if(IsConnectionExists())
      {
        using var channel = _connection.CreateModel();
        channel.QueueDeclare(_rabbitMQSettings.QueueName, exclusive: false);

        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);
        channel.BasicPublish(exchange: "", routingKey: _rabbitMQSettings.QueueName, body: body);
      }
    }

    public void SendMessageFanout<T>(T message)
    {
      if (IsConnectionExists())
      {
        using var channel = _connection.CreateModel();
        channel.ExchangeDeclare(_rabbitMQSettings.ExchangeName, ExchangeType.Fanout, durable: false);

        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);
        channel.BasicPublish(exchange: _rabbitMQSettings.ExchangeName, routingKey: "", body: body);
      }
    }

    public void SendMessageDirect<T>(T message)
    {
      if (IsConnectionExists())
      {
        using var channel = _connection.CreateModel();
        channel.ExchangeDeclare(_rabbitMQSettings.ExchangeName, ExchangeType.Direct, durable: false);

        channel.QueueDeclare("direct-message-queue-1", exclusive: false);
        channel.QueueDeclare("direct-message-queue-2", exclusive: false);

        channel.QueueBind("direct-message-queue-1", _rabbitMQSettings.ExchangeName, "routing-key-1");
        channel.QueueBind("direct-message-queue-2", _rabbitMQSettings.ExchangeName, "routing-key-2");

        var json = JsonConvert.SerializeObject(message);
        var body = Encoding.UTF8.GetBytes(json);
        channel.BasicPublish(exchange: _rabbitMQSettings.ExchangeName, routingKey: "routing-key-1", body: body);
        channel.BasicPublish(exchange: _rabbitMQSettings.ExchangeName, routingKey: "routing-key-2", body: body);
      }
    }

    private void CreateConnection()
    {
      try
      {
        ConnectionFactory factory = new ConnectionFactory
        {
          UserName = _rabbitMQSettings.UserName,
          Password = _rabbitMQSettings.Password,
          HostName = _rabbitMQSettings.HostName
        };

        _connection = factory.CreateConnection();
      }
      catch (Exception)
      {
        throw;
      }
    }

    private bool IsConnectionExists()
    {
      if(_connection != null)
      {
        return true;
      }

      CreateConnection();

      return _connection != null;
    }
  }
}