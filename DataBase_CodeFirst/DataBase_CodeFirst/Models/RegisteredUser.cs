﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase_CodeFirst.Models
{
   [Table("")]
 public  class RegisteredUser
    {
        [Key()]

        public Guid UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public bool IsDeleted { get; set; }


        //foreign key from  table department
        public int DeparmentID { get; set; }
        public Department Department { get; set; }

        //foreign key  from Gender Table
        public int GenderID { get; set; }
        public Gender Gender { get; set; }

        //foreign key  from Gender Table
        public Guid StatusID { get; set; }
        public Status Status { get; set; }
    }
}
