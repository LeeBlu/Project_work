using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer_2.Model
{
 
 public class RegisteredUser
    {
        [Key]
        public int RegisteredUserID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public bool IsDeleted { get; set; }


        public int DepartmentID { get; set; }
        public int GenderID { get; set; }
        public int StatusID { get; set; }
        public int UserTypeID { get; set; }
        public int AddressID { get; set; }

        [ForeignKey("DepartmentID")]
        public virtual Department Department { get; set; }

        [ForeignKey("GenderID")]
        public virtual Gender Gender { get; set; }

        [ForeignKey("StatusID")]
        public virtual Status Status { get; set; }

        [ForeignKey("UserTypeID")]
        public virtual UserType UserTypes { get; set; }

        [ForeignKey("AddressID")]
        public ICollection<Address> Addresses { get; set; }
    }
}
