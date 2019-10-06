using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using promo_code.Models;
using promoCode.Models;

namespace promo_code.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class PromoCodesController : ControllerBase
    {
        public PromoCodesController(TodoContext context)         
        {             
            _context = context;  
        }

        private readonly TodoContext _context;

        // GET api/promoCodes
        // Return all promo codes.
        [HttpGet]
        public ActionResult<IEnumerable<PromoCode>> Get()
        {
            return _context.PromoCodes.ToList();
        }

        // GET api/promoCodes/actives
        // Return actives promo codes.
        [HttpGet]
        [Route("actives")]
        public ActionResult<IEnumerable<PromoCode>> GetActives()
        {
            return _context.PromoCodes.Where(pc=> pc.IsActive).ToList();
        }

        // GET api/promoCodes/5
        [HttpGet("{id}")]
        public ActionResult<PromoCode> Get(long id)
        {
            var promocode = _context.PromoCodes.Find(id);
            if (promocode == null) 
            { 
                return NotFound(); 
            } 
            
            return promocode; 
        }

        // POST api/promoCodes
        // Generation of new promo codes for events.
        [HttpPost]
        public void Post([FromBody] PromoCode promoCode)
        {
            _context.PromoCodes.Add(promoCode);
            _context.SaveChanges();
        }

        // PUT api/promoCodes/5
        [HttpPut("{id}")]
        public void Put(long id, [FromBody] PromoCode promoCode)
        {
        }

        // DELETE api/promoCodes/5
        // Deactivate a promo code.
        [HttpDelete("{id}")]
        public ActionResult<PromoCode> Delete(long id)
        {
            var pc = _context.PromoCodes.Find(id);
            if (pc == null) 
            { 
                return NotFound(); 
            } 

            pc.IsActive = false;
            _context.SaveChanges();
            
            return pc; 
        }

        // GET api/promoCodes/5/validity
        // Validity a promo code.
        [HttpGet]
        [Route("{id}/validity")]
        public ActionResult<string> Validity(long id)
        {
            return "validPromoCode" + id;
        }
    }
}
