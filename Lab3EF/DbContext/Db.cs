using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Lab3EF.Models;

namespace Lab3EF.DbContext
{
    public class Db: System.Data.Entity.DbContext
    {
       
        public Db():base( @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=pizza;Integrated Security=True;")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}