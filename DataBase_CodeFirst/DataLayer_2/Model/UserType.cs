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
   public class UserType
    {
        [Key]
        public int UserTypeID { get; set; }

        public string UserDescribtion { get; set; }

        public ICollection<RegisteredUser> users { get; set; }
    }
}
