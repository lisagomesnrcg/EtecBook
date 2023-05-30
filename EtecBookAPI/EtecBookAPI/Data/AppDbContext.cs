using Microsoft.EntityFrameworkCore;
using EtecBookAPI.Models;

namespace EtecBookAPI.Data;
public class AppDbContext : DbContext
{
   public AppDbContext(DbContextOptions<AppDbContext> options) :
        base(options)
   {     
   } 

   public DbSet<AppUser> User { get; set; }    
   
   protected override void OnModelCreating(ModelBuilder modelBuilder)
   {
       base.OnModelCreating(modelBuilder);
   }
}
