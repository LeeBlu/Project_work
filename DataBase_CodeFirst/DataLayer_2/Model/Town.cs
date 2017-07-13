using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public int ProvinceID { get; set; }
        public int SurbubID { get; set; }

        [ForeignKey("ProvinceID")]
        public virtual Province province { get; set; }

        [ForeignKey("SurbubID")]
        public virtual  ICollection<Surbub> surbub { get; set; }
    }
}
