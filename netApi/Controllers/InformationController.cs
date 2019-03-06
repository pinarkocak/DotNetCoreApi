using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using netApi.Models;
using System.Web.Http;
using Microsoft.EntityFrameworkCore;
using System.Data;


namespace netApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly apiContext _info;

        public InformationController(apiContext info)
        {
            _info = info;
        }

        [HttpGet]
        public IEnumerable<Information> Get()
        {
            return _info.Information.ToList();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var inf = _info.Information.FirstOrDefault(t => t.InfoId == id);
            if (inf == null)
                return NotFound();

            return new ObjectResult(inf);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        {
            
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {

        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }
    }
}