using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace promo_code.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromoCodesController : ControllerBase
    {
        // GET api/promoCodes
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "promoCode1", "promoCode2" };
        }

        // GET api/promoCodes/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "promoCode";
        }

        // POST api/promoCodes
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/promoCodes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
    }
}
