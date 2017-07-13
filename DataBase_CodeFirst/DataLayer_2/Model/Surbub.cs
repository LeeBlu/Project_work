using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int TownID { get; set; }
        public int AddressID { get; set; }

        [ForeignKey("TownID")]
        public virtual Town town { get; set; }

        [ForeignKey("AddressID")]
        public virtual ICollection<Address> addresses { get; set; }
    }
}
