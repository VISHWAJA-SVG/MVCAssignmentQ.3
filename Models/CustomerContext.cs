using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Q._3CMS.Ass.Models
{
    public class CustomerContext:DbContext
    {
        //Constructor calling the DbContext class constructor
        public CustomerContext():base("CMSPORTALassignment")
        {

        }
        //Adding Domain Classes as DbSet
        public DbSet<Customer> Customers { get; set; }
    }
}