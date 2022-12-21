namespace RabbitMQ_Producer.Models
{
  public class RabbitMQSettings
  {
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public string HostName { get; set; } = string.Empty;
    public string QueueName { get; set; } = string.Empty;
    public string ExchangeName { get; set; } = string.Empty;
  }
}
