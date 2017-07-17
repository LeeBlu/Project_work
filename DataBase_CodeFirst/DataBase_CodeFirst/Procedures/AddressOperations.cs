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

        public string UpdateAddress(int id, Address upadd,int? subID,int? typeId)
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


                    if ( typeId != null)
                    {
                        var type = db.addresstypes.Where(s => s.AddressTypeID == typeId).FirstOrDefault();
                        tempaddress.Addresstypes  = type;
                    }


                    if (subID != null)
                    {
                        var sub = db.surbubs.Where(s=>s.SurbubID==subID).FirstOrDefault();

                        tempaddress.sub = sub;
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
