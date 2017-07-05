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
            List<RegisteredUser> user = new List<RegisteredUser>();
            
            using (var db = new TableContext())
            {
                var person = db.Ruser.Find(id);
                user.Add(person);
                var type = db.addresstype.Find(addtype);
                addres.Addresstype = type;
                addres.user = user;
                db.addresse.Add(addres);
                db.SaveChanges();

            }

        }
        public Address GetAddress(int id)
        {
        
            using (var db =new TableContext())
            {
                var temp = db.addresse.Where(s=>s.AddressID==id).FirstOrDefault();
                return temp;
            }

        }

        public void DeleteAddress(int id)
        {
            using (var db =new TableContext())
            {
                var readdress = db.addresse.Find(id);
                db.addresse.Remove(readdress);
                db.SaveChanges();
            }
        }

        public void UpdateAddress(int id, Address upadd)
        {
            using (var db = new TableContext())
            {
                
                    var readdress = db.addresse.Find(id);
                
                    if (readdress != null)
                    {
                        readdress = upadd;
                        db.Entry(readdress).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }
               
             
            }
        }

    }
}
