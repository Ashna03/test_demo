using Family_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Family_DAL.Data
{
    public class FamilyDBContext : DbContext               //Inherit DbContext in context class
    {
        public FamilyDBContext(DbContextOptions<FamilyDBContext> options) : base(options)   //constructor
        { 
        
        }

        public DbSet<Person> Persons { get; set; }          //Person is class, Persons is created in db
        //protected override void onModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
    }
}
