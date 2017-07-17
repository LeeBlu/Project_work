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
            //RegisteredUser user = new RegisteredUser();
            try
            {
                using (var db = new TableContext())
                {
                    var person = db.Rusers.Where(s => s.RegisteredUserID == id).FirstOrDefault();
                    var type = db.addresstypes.Find(addtype);
                    addres.Addresstypes = type;
                    var sub = db.surbubs.Find(subid);
                    addres.sub = sub;
                    addres.RegisteredUsers = person;
                    db.addresses.Add(addres);
                    db.SaveChanges();

                }
                return "address was added";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }
          


        }

        public string UpdateAddress(int id, Address upadd)
        {
            Address tempaddress = new Address();

            using (var db = new TableContext())
            {
                var readdress = db.addresses.Find(id);

                tempaddress = readdress;
                try
                {

                    if (upadd.UnitNumber != "")
                    {
                        tempaddress.UnitNumber = upadd.UnitNumber;
                    }


                    if (upadd.StreetName!="")
                    {
                        tempaddress.StreetName  = upadd.StreetName;
                    }


                    if (upadd.ComplexNumber != "")
                    {
                        tempaddress.ComplexNumber = upadd.ComplexNumber;
                    }


                    if (upadd.Addresstypes != null)
                    {
                        tempaddress.Addresstypes  = upadd.Addresstypes;
                    }


                    if (upadd.sub != null)
                    {
                        tempaddress.sub = upadd.sub;
                    }
                    if (upadd.SurbubID!=null)
                    {

                    }

            

                    
                    db.Entry(tempaddress).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return "address was updated";
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
               



           } 
        }




    }
}
