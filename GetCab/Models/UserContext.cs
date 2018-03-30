using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace GetCab.Models
{
    public class UserContext : DbContext
    {
        public UserContext() :
            base("DegaultConnection")
        { }

        public DbSet<User> Users { get; set; }


        public string Login { get; set; }
        public int MyProperty { get; set; }
    }
}