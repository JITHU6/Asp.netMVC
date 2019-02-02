using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace StudentInfo.Models
{
    public class UserContext:DbContext
    {
        public  UserContext()
            :base("Mycon")
        {
            DropCreateDatabaseIfModelChanges<UserContext> a = new DropCreateDatabaseIfModelChanges<UserContext>();
            Database.SetInitializer<UserContext>(a);
        }
        public DbSet<Registration> registrations { get; set; }

        public DbSet<Department> Departments { get; set; }

        public DbSet<StudInfo> StudInfos { get; set; }
    }
}