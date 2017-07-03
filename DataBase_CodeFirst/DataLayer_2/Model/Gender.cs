using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer_2.Model
{

  public class Gender
    {
        [Key]
        public int GenderID { get; set; }

        public string GenderDescription { get; set; }

        public virtual ICollection<RegisteredUser> users { get; set; }
    }
}
