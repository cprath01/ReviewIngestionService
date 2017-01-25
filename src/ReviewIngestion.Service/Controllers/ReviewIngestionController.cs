using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.WebApiCompatShim;
using ReviewIngestion.Domain.Engine.Interfaces;
using ReviewIngestion.Domain.Common.Objects;
using System.Net.Http;

namespace ReviewIngestion.Service.Controllers
{
    [Route("api/[controller]")]
    public class ReviewIngestionController : Controller
    {
        private readonly IReviewEngine _reviewEngine;

        public ReviewIngestionController(IReviewEngine reviewEngine)
        {
            _reviewEngine = reviewEngine;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var product = _reviewEngine.GetReviews(id);

            if(product == null)
                return NoContent();
            else
                return new ObjectResult(product);
        }
    }
}
