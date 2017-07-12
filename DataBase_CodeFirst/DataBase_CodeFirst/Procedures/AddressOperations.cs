using DataLayer_2.ContextFolder;
using DataLayer_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_CodeFirst.Procedures
{
    class AddressOperations
    {
        public string InsertAddress(Address addres, int id, int addtype, int subid)
        {
            RegisteredUser user = new RegisteredUser();

            using (var db = new TableContext())
            {
                var person = db.Rusers.Where(s => s.RegisteredUserID == id).FirstOrDefault();
                var type = db.addresstypes.Find(addtype);
                addres.Addresstypes = type;
                var sub = db.surbubs.Find(subid);
                addres.sub = sub;
                addres.RegisteredUsers = user;
                db.addresses.Add(addres);
                db.SaveChanges();

            }
            return "address was added";


        }

        public void UpdateAddress(int id, Address upadd)
        {
            using (var db = new TableContext())
            {

                var readdress = db.addresses.Find(id);

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
