using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using promo_code.Models;
using promoCode.Models;

namespace promo_code.Services
{
    public class PromoCodeService
    {
        public PromoCodeService(TodoContext context)         
        {             
            _context = context;  
        }

        private readonly TodoContext _context;

        public ActionResult<IEnumerable<PromoCode>> GetAll()
        {
            return _context.PromoCodes.ToList();
        }

        public ActionResult<IEnumerable<PromoCode>> GetActives()
        {
            return _context.PromoCodes.Where(pc=> pc.IsActive).ToList();
        }

        public ActionResult<PromoCode> GetById(long id)
        {
            var promocode = _context.PromoCodes.Find(id);            
            return promocode; 
        }

        public void Create(PromoCode promoCode)
        {
            _context.PromoCodes.Add(promoCode);
            _context.SaveChanges();
        }

        public ActionResult<PromoCode> Change(long id, PromoCode promoCode)
        {
            var pc = _context.PromoCodes.Find(id);
            if (pc == null) 
            { 
                return null; 
            } 
            
            pc.Description = ValueToChange(pc.Description, promoCode.Description); 
            pc.ExpireDate = ValueToChange(pc.ExpireDate, promoCode.ExpireDate);
            pc.Amount = ValueToChange(pc.Amount, promoCode.Amount);
            pc.RadiusInKilometers = ValueToChange(pc.RadiusInKilometers, promoCode.RadiusInKilometers);
            pc.CoordinateLat = ValueToChange(pc.CoordinateLat, promoCode.CoordinateLat);
            pc.CoordinateLon = ValueToChange(pc.CoordinateLon, promoCode.CoordinateLon);

            _context.SaveChanges();
            
            return pc; 
        }

        public ActionResult<PromoCode> Deactivate(long id)
        {
            var pc = _context.PromoCodes.Find(id);
            if (pc == null) 
            { 
                return null; 
            } 

            pc.IsActive = false;
            _context.SaveChanges();
            
            return pc; 
        }

        public ActionResult<bool> Validity(long id)
        {
            var pc = _context.PromoCodes.Find(id);
            if (pc == null) 
            { 
                return null; 
            }

            if (pc.ExpireDate < DateTime.Now) {
                return false;
            }

            if (pc.Amount.Equals(0)) {
                return false;
            }

            //I'll use the Haversine Formula here


            return false;
        }

        private dynamic ValueToChange (dynamic originalValue, dynamic value) {
            return (originalValue == value || value == null) ? originalValue : value;
        }

    }
}