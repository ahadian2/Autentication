using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace Autentication.Models
{
    public class MyDbContext:DbContext
    {
        public DbSet<Users> Users { get; set; }
    }
}