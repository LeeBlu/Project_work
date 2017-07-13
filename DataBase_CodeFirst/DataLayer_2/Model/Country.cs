using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_2.Model
{
  public  class Country
    {
        [Key]
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public int ProvinceID { get; set; }

        [ForeignKey("AddressID")]
        public virtual ICollection<Province> provinces { get; set; }
    }
}
