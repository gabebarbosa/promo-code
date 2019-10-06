using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using promo_code.Models;
using promo_code.Services;
using promoCode.Models;

namespace promo_code.Controllers
{
   
    [Route("api/[controller]")]
    [ApiController]
    public class PromoCodesController : ControllerBase
    {
        public PromoCodesController(TodoContext context)         
        {             
            _service = new PromoCodeService(context);  
        }

        private readonly PromoCodeService _service;

        // GET api/promoCodes
        // Return all promo codes.
        [HttpGet]
        public ActionResult<IEnumerable<PromoCode>> Get()
        {
            return _service.GetAll();
        }

        // GET api/promoCodes/actives
        // Return actives promo codes.
        [HttpGet]
        [Route("actives")]
        public ActionResult<IEnumerable<PromoCode>> GetActives()
        {
            return _service.GetActives();
        }

        // GET api/promoCodes/5
        [HttpGet("{id}")]
        public ActionResult<PromoCode> Get(long id)
        {
            var promocode = _service.GetById(id);
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
            _service.Create(promoCode);
        }

        // PUT api/promoCodes/5
        [HttpPut("{id}")]
        public ActionResult<PromoCode> Put(long id, [FromBody] PromoCode promoCode)
        {
            var pc = _service.Change(id, promoCode);
            if (pc == null) 
            { 
                return NotFound(); 
            }
            
            return pc; 
        }

        // DELETE api/promoCodes/5
        // Deactivate a promo code.
        [HttpDelete("{id}")]
        public ActionResult<PromoCode> Delete(long id)
        {
            var pc = _service.Deactivate(id);
            if (pc == null) 
            { 
                return NotFound(); 
            }
            
            return pc; 
        }

        // GET api/promoCodes/5/validity
        // Validity a promo code.
        [HttpGet]
        [Route("{id}/validity")]
        public ActionResult<bool> Validity(
            long id, 
            [FromQuery] string originLat, 
            [FromQuery] string originLon, 
            [FromQuery] string destinationLat,
            [FromQuery] string destinationLon)
        {
            if (string.IsNullOrEmpty(originLat) || string.IsNullOrEmpty(originLon)) {
                return StatusCode(400, "Enter the origin coordinate");
            }
            if (string.IsNullOrEmpty(destinationLat) || string.IsNullOrEmpty(destinationLon)) {
                return StatusCode(400, "Enter the destination coordinate");
            }

            var isValid = _service.Validity(id);

            if (isValid == null) {
                return NotFound();
            }

            return isValid;

        }
    }
}
