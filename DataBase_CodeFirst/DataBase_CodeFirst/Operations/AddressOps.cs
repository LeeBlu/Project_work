using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer_2.ContextFolder;
using DataLayer_2.Model;

namespace DataBase_CodeFirst.Operations
{
    
   public class AddressOps
    {
    

        public void InsertAddress(Address addres,int id,int addtype)
        {
            using (var db = new TableContext())
            {
                if ()
                {
                    var type = db.addresstype.Find(addtype);
                    addres.Addresstype = type;
                    db.addresse.Add(addres);
                    db.SaveChanges();
                    addres.a
                }
                
            }

        }

    }
}
