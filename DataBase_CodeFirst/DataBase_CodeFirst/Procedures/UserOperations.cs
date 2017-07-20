using System;
using System.Collections.Generic;
using System.Linq;
//using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using DataLayer_2.ContextFolder;
using DataLayer_2.Model;


namespace DataBase_CodeFirst.Procedures
{
    class UserOperations
    {
        public string AddUser(RegisteredUser user, int depId, int gid)
        {
            using (var db = new TableContext())
            {
                try
                {

                    var tempstatus = db.statuses.Find(2);
                    var tempGender = db.Genders.Find(gid);
                    var tempdep = db.departments.Find(depId);
                    var temptype = db.Usertypes.Find(2);
                    user.IsDeleted = false;
                    user.Status = tempstatus;

                    user.Department = tempdep;
                    user.UserTypes = temptype;
                    user.Gender = tempGender;
                    db.Rusers.Add(user);
                    db.SaveChanges();



                    return "User was added";
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        
        }

        public string UpdateUser(int id, RegisteredUser updateinfo)
        {
            RegisteredUser temp = new RegisteredUser();
            using (var db = new TableContext())
            {
                var tempuser = db.Rusers.Where(s => s.RegisteredUserID == id).FirstOrDefault();
                temp = tempuser ;

                if (!string.IsNullOrEmpty(updateinfo.EmailAddress))
                {
                    temp.EmailAddress = updateinfo.EmailAddress;
                }

               if (!string.IsNullOrEmpty(updateinfo.FirstName))
                {
                    temp.FirstName = updateinfo.FirstName;
                }

                if (!string.IsNullOrEmpty(updateinfo.LastName))
                {
                    temp.LastName = updateinfo.LastName;
                }
    

                if (!string.IsNullOrEmpty(updateinfo.Password))
                {
                    temp.Password = updateinfo.Password;
                }
        


              
                db.Entry(temp).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

            }
            return "user was updated";


        }

        public string ActivateUser(int id)
        {

            using (var db = new TableContext())
            {
                var st = db.statuses.Find(1);
                var tempuser = db.Rusers.Where(s => s.RegisteredUserID == id).FirstOrDefault();
                tempuser.Status = st;
                db.Entry(tempuser).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return "User was Activated";
        }

        public string DeactivateUser(int id)
        {

            using (var db = new TableContext())
            {
                var st = db.statuses.Find(2);
                var tempuser = db.Rusers.Where(s => s.RegisteredUserID == id).FirstOrDefault();
                tempuser.Status = st;
                db.Entry(tempuser).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return "User was Deactivated";
        }

        public string SoftDeleteUser(int id)
        {

            using (var db = new TableContext())
            {
                
                var tempuser = db.Rusers.Where(s => s.RegisteredUserID == id).FirstOrDefault();
                //tempuser.IsDeleted=true;
                tempuser.IsDeleted = true;
                db.Entry(tempuser).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
            return "User was Deleted";
        }


        public void UserInfo()
        {
            using (var db = new TableContext())

            {
                var temp = db.Rusers.Where(x => x.Status.StatusDesc == "UnActive").Select(y => new
                {
                    y.FirstName,
                    y.LastName,
                    y.EmailAddress,
                    y.Gender.GenderDescription,
                    y.Department.DepartmentName,
                    y.Addresses.FirstOrDefault().ComplexNumber,
                    y.Addresses.FirstOrDefault().StreetName,
                    y.Addresses.FirstOrDefault().sub.SuburbName,
                    y.Addresses.FirstOrDefault().sub.town.TownName,
                    y.Addresses.FirstOrDefault().sub.town.province.ProvinceName,
                    y.Addresses.FirstOrDefault().sub.town.province.country.CountryName
                });
            }

        }

     }

 }



//var qry = objUsersDbContext.User.Where(x => x.IsApproved == false).Select(y => new { y.PkUserId, y.FirstName, y.MiddleName, y.LastName, y.Gender.GenderValue, y.Department.DepartmentName, y.PhysicalAddress.FirstOrDefault().StreetLine1, y.PhysicalAddress.FirstOrDefault().StreetLine2, y.PhysicalAddress.FirstOrDefault().StreetLine3 });