using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CodealongEF.Models
{
    public class PeopleDbContext : DbContext
    {
        public PeopleDbContext() : base("name=PeopleDbContext")
        {

        }

        public DbSet<Person> people { get; set; }

    }
}