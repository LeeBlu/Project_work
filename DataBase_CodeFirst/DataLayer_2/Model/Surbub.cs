using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_2.Model
{
  public class Surbub
    {
        [Key]
        public int SurbubID { get; set; }

        public string SuburbName { get; set; }

        public virtual Town town { get; set; }
        public virtual ICollection<Address> addresses { get; set; }
    }
}
