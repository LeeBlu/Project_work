using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer_2.ContextFolder;
using DataLayer_2.Model;

namespace DataBase_CodeFirst.Operations
{

    class UserOps
    {
        public string AddUser(RegisteredUser us, int depid,int gid)
        {
            using (var db = new TableContext())
            {
                var tempstatus = db.statuse.Find(2); 
                var tempGender = db.Gender.Find(gid);
                var tempdep = db.department.Find(depid);
                var temptype = db.Usertype.Find(2);
                us.IsDeleted = false;
                us.Status=tempstatus;
            
                us.Department= tempdep;
                us.usertype= temptype;
                us.Gender = tempGender;
                db.Ruser.Add(us);
                db.SaveChanges();
            }
            return "User was added";
        }

    }
}
