using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_2.Model
{
   public class AddressType
    {
       [Key]
        public int AddressTypeID { get; set; }

        public string AddressTypeDecs { get; set; }
        public int AddressID { get; set; }

        [ForeignKey("AddressID")]
        public virtual ICollection<Address> addresses { get; set; }
    }
}
