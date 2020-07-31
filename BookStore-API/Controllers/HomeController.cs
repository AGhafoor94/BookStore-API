using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStore_API.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore_API.Controllers
{
    /// <summary>
    /// This is a test controller
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILoggerService _logger;
        public HomeController(ILoggerService logger)
        {
            _logger = logger;
        }
        /// <summary>
        /// Gets Values
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<string> GetAll()
        {
            _logger.LogInfo("Accessed Home Controller");
            return new string[] { "value1", "value2" };
        }
        /// <summary>
        /// Gets certain value by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public string GetById(int id)
        {
            return "Hello";
        }
        /// <summary>
        /// Posting data to api from body
        /// </summary>
        /// <param name="value"></param>
        [HttpPost]
        public void Post([FromBody] string value) { }
        /// <summary>
        /// Updating value by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }
        /// <summary>
        /// Deleting item by id
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public void Delete(int id) { }
    }
}
