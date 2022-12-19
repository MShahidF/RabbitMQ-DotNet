using RabbitMQ_Producer.Models;

namespace RabbitMQ_Producer.Repositories
{
  public class CountryRepository
  {
    public static List<Country> Countries = new List<Country>()
    {
      new Country() { CountryId = 1, CountryName = "Pakistan" },
      new Country() { CountryId = 2, CountryName = "Saudi Arabia"}
    };
  }
}
