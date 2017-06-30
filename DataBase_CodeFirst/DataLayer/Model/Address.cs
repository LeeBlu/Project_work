using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DataBase_CodeFirst.Models;  

namespace DataBase_CodeFirst.Models
{
   
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        public string UnitNumber { get; set; }

        public string StreetName { get; set; }

        public string PostalAddress { get; set; }

        public virtual AddressType Addresstype { get; set; }

        public virtual Surbub sub { get; set; }

        public UserAddress useraddress { get; set; }



    }
}
