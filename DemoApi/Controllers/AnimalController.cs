using System.Collections.Generic;
using System.Linq;
using DemoApi.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnimalController : ControllerBase
    {

        private static IList<Animal> _forest = new List<Animal>();
        /// <summary>
        /// get command fetch collection of data
        /// </summary>
        /// <returns></returns>
        // GET: api/<AnimalController>
        [HttpGet]
        public IEnumerable<Animal> Get()
        {
            return _forest;
        }
        /// <summary>
        /// get single record of a given id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/<AnimalController>/5
        [HttpGet("{id}")]
        public Animal Get(int id)
        {
            return _forest.Where(a=>a.Id ==id).FirstOrDefault();
        }
        /// <summary>
        /// data addition operation
        /// </summary>
        /// <param name="value"></param>
        // POST api/<AnimalController>
        [HttpPost]
        public void Post([FromBody] Animal animal)
        {

            _forest.Add(animal);
        }
        /// <summary>
        /// Data edit operation
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/<AnimalController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Animal value)
        {
        }
        /// <summary>
        /// Delete operation
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/<AnimalController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var animal=_forest.Where(a => a.Id == id).FirstOrDefault();
            _forest.Remove(animal);
        }
    }
}
