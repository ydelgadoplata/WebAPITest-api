using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAPITest.DataADONET;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ValuesRepository _repository;

        public ValuesController(ValuesRepository repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }
        
        // GET api/values
        [HttpGet]
        public async Task<List<ValueEjm>> Get()
        {
            return await _repository.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ValueEjm>> Get(int id)
        {
            var response = await _repository.GetById(id);
            if (response == null)
            {
                return NotFound();
            }
            return response;
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody] ValueEjm value)
        {
            await _repository.Insert(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _repository.DeleteById(id);
        }
    }
}
