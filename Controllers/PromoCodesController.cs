using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using promoCode.Models;

namespace promo_code.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromoCodesController : ControllerBase
    {
        // GET api/promoCodes
        // Return all promo codes.
        [HttpGet]
        public ActionResult<IEnumerable<PromoCode>> Get()
        {
            return new PromoCode[] { new PromoCode(), new PromoCode(), };
        }

        // GET api/promoCodes/actives
        // Return actives promo codes.
        [HttpGet]
        [Route("actives")]
        public ActionResult<IEnumerable<PromoCode>> GetActives()
        {
            return new PromoCode[] { new PromoCode(), new PromoCode(), };
        }

        // GET api/promoCodes/5
        [HttpGet("{id}")]
        public ActionResult<PromoCode> Get(int id)
        {
            return new PromoCode();
        }

        // POST api/promoCodes
        // Generation of new promo codes for events.
        [HttpPost]
        public void Post([FromBody] PromoCode promoCode)
        {
        }

        // PUT api/promoCodes/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] PromoCode promoCode)
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
