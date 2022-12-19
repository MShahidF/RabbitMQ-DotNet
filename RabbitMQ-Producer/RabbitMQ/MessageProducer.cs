using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ_Producer.Models;
using Microsoft.Extensions.Options;

namespace RabbitMQ_Producer.RabbitMQ
{
  public class MessageProducer : IMessageProducer
  {
    private readonly RabbitMQSettings _rabbitMQSettings;

    public MessageProducer(IOptions<RabbitMQSettings> options)
    {
      _rabbitMQSettings = options.Value;
    }

    public void SendMessage<T>(T message)
    {
      ConnectionFactory factory = new ConnectionFactory
      {
        UserName = _rabbitMQSettings.UserName, 
        Password = _rabbitMQSettings.Password,
        HostName = _rabbitMQSettings.HostName
      };

      var connection = factory.CreateConnection();
      using var channel = connection.CreateModel();
      channel.QueueDeclare(_rabbitMQSettings.QueueName, exclusive: false);

      var json = JsonConvert.SerializeObject(message);
      var body = Encoding.UTF8.GetBytes(json);
      channel.BasicPublish(exchange: "", routingKey: _rabbitMQSettings.QueueName, body: body);
    }
  }
}