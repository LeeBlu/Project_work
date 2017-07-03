using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_2.Model
{
    public class Town
    {
        [Key]
        public int TownID { get; set; }

        public string TownName { get; set; }

        public virtual Province province { get; set; }
        public virtual  ICollection<Surbub> surbub { get; set; }
    }
}
