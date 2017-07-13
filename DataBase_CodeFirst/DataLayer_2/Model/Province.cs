using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_2.Model
{
   public  class Province
    {
        [Key]
        public int ProvinceID { get; set; }

        public string ProvinceName { get; set; }

        public int CountryID { get; set; }
        public int TownID { get; set; }

        [ForeignKey("CountryID")]
        public virtual Country country { get; set; }

        [ForeignKey("TownID")]
        public virtual ICollection<Town> towns { get; set; }
    }
}
