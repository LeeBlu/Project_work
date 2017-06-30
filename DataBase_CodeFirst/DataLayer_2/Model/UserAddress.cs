using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer_2.Model
{
    public class UserAddress
    {
        public virtual ICollection<RegisteredUser> user { get; set; }

        public virtual ICollection<Address> address { get; set; }
    }
}
