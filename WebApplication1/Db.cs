using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication1.Models;

namespace WebApplication1
{
    public class Db : System.Data.Entity.DbContext
    {
        public Db() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=animals;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

        { }


        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalGroup> AnimalGroups { get; set; }

    }
}