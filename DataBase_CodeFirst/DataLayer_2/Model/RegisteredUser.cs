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

        public virtual Department Department { get; set; }

        public virtual Gender Gender { get; set; }

        public virtual Status Status { get; set; }
    }
}
