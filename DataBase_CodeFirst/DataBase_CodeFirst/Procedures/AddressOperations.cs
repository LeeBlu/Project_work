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
                addres.Addresstype = type;
                var sub = db.surbubs.Find(subid);
                addres.sub = sub;
                addres.user = user;
                db.addresses.Add(addres);
                db.SaveChanges();

            }
            return "address was added";


        }
    }
