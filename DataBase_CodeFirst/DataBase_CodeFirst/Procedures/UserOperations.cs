using System;
using System.Collections.Generic;
using System.Linq;
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

               if (updateinfo.FirstName!="")
                {
                    temp.FirstName = updateinfo.FirstName;
                }

                if (updateinfo.LastName != "")
                {
                    temp.LastName = updateinfo.LastName;
                }
    

                if (updateinfo.Password!="")
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
                //var UserInfomation = from us in db.Rusers
                //                     join b in db.addresses
                //                     on us.RegisteredUserID equals b.RegisteredUserID
                //                     join g in db.Genders on us.GenderID equals g.GenderID
                //                     join d in db.departments on us.DepartmentID equals d.DepartmentID

                //                     select new
                //                     {
                //                         firstname = us.FirstName,
                //                         lastname = us.LastName,
                //                         strName = b.StreetName,
                //                         untNo = b.UnitNumber,
                //                         Sex = g.GenderDescription,
                //                         DepName = d.DepartmentName,
                //                         DepDesc = d.DepartmentDescrption

                //                     };
                //foreach (var item in UserInfomation)
                //{
                //    Console.WriteLine("firstName {0} lastName{1} StreetName {2} UnitNo{3} GenderDec{4} DepName {5} DepDesc {6}", item.firstname, item.lastname, item.strName, item.untNo, item.Sex, item.DepName, item.DepDesc);

                //}
                //Console.ReadLine();

                var temp = db.Rusers.Where(s => s.Status.StatusDesc == "UnActive");
            }

        }

     //   var obj = context.Profiles.Where(_ => _.ProfileID == 1).Select(_ => new { _.Addresses.First().StreetName, _.Department.DepartmentID })};
}

 }

