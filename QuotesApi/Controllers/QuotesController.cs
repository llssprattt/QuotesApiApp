using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuotesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuotesApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    
    public class QuotesController : ControllerBase
    {
        static List<Quote> _quotes = new List<Quote>()
       {
           new Quote(){Id = 1, Author = "Emily Dickerson", Description= "The brain is wider than the sky,", Title="Inspriaction"},
           new Quote(){Id = 1, Author = "Richard Bach", Description= "Love stinks", Title="Love Story"}
       };

        [HttpGet]
        public IEnumerable<Quote> Get()
        {
            return _quotes;
        }

        [HttpPost]
        public void Post(Quote quote)
        {
            _quotes.Add(quote);
        }
    }
}
