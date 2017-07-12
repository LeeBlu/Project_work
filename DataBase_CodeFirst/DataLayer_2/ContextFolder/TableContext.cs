using DataLayer_2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_2.ContextFolder
{
   public  class TableContext :DbContext
    {
        public DbSet<Department> departments { get; set; }

        public DbSet<RegisteredUser> Rusers { get; set; }

        public DbSet<Country> countries { get; set; }

        public DbSet<Province> provincies { get; set; }

        public DbSet<Town> towns { get; set; }

       
        public DbSet<UserType> Usertypes { get; set; }

        public DbSet<Address> addresses { get; set; }

        public DbSet<AddressType> addresstypes { get; set; }

        public DbSet<Gender> Genders { get; set; }

        public DbSet<Surbub> surbubs { get; set; }

        public DbSet<Status> statuses { get; set; }

        
    }
}
