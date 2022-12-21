namespace RabbitMQ_Producer.RabbitMQ
{
  public interface IMessageProducer
  {
    void SendMessage<T>(T message);
    void SendMessageFanout<T>(T message);
    void SendMessageDirect<T>(T message);
  }
}