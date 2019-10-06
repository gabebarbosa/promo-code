using Microsoft.EntityFrameworkCore;  
using promoCode.Models;

namespace promo_code.Models
{
    public class TodoContext : DbContext     
    {         
        public TodoContext(DbContextOptions<TodoContext> options): base(options){}       
        public DbSet<PromoCode> PromoCodes { get; set; }     
  
   } 

}