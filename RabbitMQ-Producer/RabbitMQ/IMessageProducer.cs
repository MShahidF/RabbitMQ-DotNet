﻿namespace RabbitMQ_Producer.RabbitMQ
{
  public interface IMessageProducer
  {
    void SendMessage<T>(T message);
  }
}