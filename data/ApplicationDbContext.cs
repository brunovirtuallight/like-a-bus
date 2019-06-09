using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using bus.Models; 

namespace bus.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
          
         public DbSet<Bus_Route> Bus_Route {get; set;}

          public DbSet<Bus> Bus {get; set;}

        
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

    }
}