using System;

namespace promoCode.Models
{
    public class PromoCode
    {
        public long Id { get; set; }        
        public string Description { get; set; }         
        public DateTime ExpireDate { get; set; }
        public int Amount { get; set; }
        public bool IsActive { get; set; }
        public string Radius { get; set; }
    }
}