using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_CodeFirst.Models
{
  public class Surbub
    {
        [Key]
        public int SurbubID { get; set; }

        public string SuburbName { get; set; }

        public virtual Town town { get; set; }
        public ICollection<Address> addresses { get; set; }
    }
}
