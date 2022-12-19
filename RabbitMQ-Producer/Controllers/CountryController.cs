﻿using Microsoft.AspNetCore.Mvc;
using RabbitMQ_Producer.Models;
using RabbitMQ_Producer.RabbitMQ;
using RabbitMQ_Producer.Repositories;

namespace RabbitMQ_Producer.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CountryController : ControllerBase
  {
    private readonly IMessageProducer _messagePublisher;

    public CountryController(IMessageProducer messagePublisher)
    {
      _messagePublisher = messagePublisher;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      try
      {
        var countries = CountryRepository.Countries.ToList();

        return Ok(countries);
      }
      catch (Exception ex)
      {
        return StatusCode(500, ex.Message);
      }
    }

    [HttpPost]
    public IActionResult CreateCountry([FromBody] Country country)
    {
      try
      {
        CountryRepository.Countries.Add(country);

        _messagePublisher.SendMessage(country);

        return Ok();
      }
      catch (Exception ex)
      {
        return StatusCode(500, ex.Message);
      }
    }
  }
}
