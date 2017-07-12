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
