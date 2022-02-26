using System.Collections.Generic;
using Kodplus.Business.Interfaces;
using Kodplus.Dataaccess.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kodplus.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IArticleService _articleGenericService;
        
        public ValuesController(IArticleService articleGenericService)
        {
            _articleGenericService = articleGenericService;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public OkObjectResult Get()
        {
            var values= _articleGenericService.GetAll();
            return Ok(values);
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var values= _articleGenericService.GetById(id);
            return Ok(values);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public IActionResult Post(Article article)
        {
           _articleGenericService.Insert(article);
            return Ok();
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Article article)
        {
          _articleGenericService.Update(article);
          return Ok();
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _articleGenericService.Delete(id);
            return Ok();
        }
    }
}
