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
    [Table("Addresses")]
    public class Addreses
    {
        public Guid AddressID { get; set; }
        public string UnitNumber { get; set; }
        public string StreetName { get; set; }
        public string PostalAddress { get; set; }
        // foreign key 
        public Guid AddressTypeID { get; set; }
        public AddressType AddressTypes { get; set; }


    }
}
