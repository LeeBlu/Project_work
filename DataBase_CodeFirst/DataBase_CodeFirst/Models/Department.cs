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
    [Table("")]
 public   class Department
    {

        [Key()]
        public Guid DeparmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmesntDescrption { get; set; }
    }
}
