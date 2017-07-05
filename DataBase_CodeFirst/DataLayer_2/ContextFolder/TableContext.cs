using DataLayer_2.Model;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_2.ContextFolder
{
   public  class TableContext :DbContext
    {

        //public TableContext():base("newdatabase")
        //{

        //}
        public DbSet<Department> department { get; set; }

        public DbSet<RegisteredUser> Ruser { get; set; }

        public DbSet<Country> country { get; set; }

        public DbSet<Province> province { get; set; }

        public DbSet<Town> town { get; set; }

       // public DbSet<UserAddress> useraddresses { get; set; }

        public DbSet<UserType> Usertype { get; set; }

        public DbSet<Address> addresse { get; set; }

        public DbSet<AddressType> addresstype { get; set; }

        public DbSet<Gender> Gender { get; set; }

        public DbSet<Surbub> surbub { get; set; }

        public DbSet<Status> statuse { get; set; }

        
    }
}
