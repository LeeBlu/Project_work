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
        public string AddUser(RegisteredUser user ,int depId,int gid)
        {
            using (var db =new TableContext())
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
            using (var db = new TableContext())
            {
                var tempuser = db.Rusers.Where(s => s.RegisteredUserID == id).FirstOrDefault();
                tempuser = updateinfo;
                db.Entry(tempuser).State = System.Data.Entity.EntityState.Modified;
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

        public RegisteredUser UserInfo(int id)
        {
        }

    }
}
