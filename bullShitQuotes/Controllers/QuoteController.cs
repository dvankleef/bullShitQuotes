using System;
using System.Collections.Generic;
using System.Linq;
using bullShitQuotes.Models;
using Microsoft.AspNetCore.Mvc;

namespace bullShitQuotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly Quote[] _quotes = new Quote[]
        {
            new Quote {text = "Het is wat het is"},
            new Quote {text = "Dingen op het juiste moment juist"},
            new Quote {text = "Kort op de bal"},
            new Quote {text = "Omwille van de tijd"},
        };

        public ActionResult<IEnumerable<Quote>> GetAllProducts()
        {
            return _quotes;
        }

        // GET: api/Quote
        [HttpGet]
        public IEnumerable<Quote> GetAllQuotes()
        {
            return _quotes;
        }

        [HttpGet("/random")]
        public string GetRandomQuote()
        {
            var random = new Random();

            int r = random.Next(_quotes.ToList().Count);

            return _quotes[r].text;
        }
    }
}