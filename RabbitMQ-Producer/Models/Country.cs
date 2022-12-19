namespace RabbitMQ_Producer.Models
{
  public class Country
  {
    public int CountryId { get; set; }
    public string CountryName { get; set; } = string.Empty;
    public DateTime CreatedDate { get; set; } = DateTime.Now;
  }
}
