using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataBase_CodeFirst.Models
{

  public  class Gender
    {
        [Key()]
        public Guid GenderID { get; set; }
        public string GenderDescription { get; set; }
    }
}
