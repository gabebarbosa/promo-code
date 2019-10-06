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
        // Return all promo codes.
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "promoCode1", "promoCode2" };
        }

        // GET api/promoCodes/actives
        // Return actives promo codes.
        [HttpGet]
        [Route("actives")]
        public ActionResult<IEnumerable<string>> GetActives()
        {
            return new string[] { "activePromoCode1", "activePromoCode2" };
        }

        // GET api/promoCodes/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "promoCode";
        }

        // POST api/promoCodes
        // Generation of new promo codes for events.
        [HttpPost]
        public void Post([FromBody] string promoCode)
        {
        }

        // PUT api/promoCodes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string promoCode)
        {
        }

        // DELETE api/promoCodes/5
        // Deactivate a promo code.
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // GET api/promoCodes/5/validity
        // Validity a promo code.
        [HttpGet]
        [Route("{id}/validity")]
        public ActionResult<string> Validity(int id)
        {
            return "validPromoCode" + id;
        }
    }
}
