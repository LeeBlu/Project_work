using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer_2.ContextFolder;
using DataLayer_2.Model;
using System.Data.Entity;

namespace DataBase_CodeFirst.Procedures
{
    class UpdatedUser
    {
        public void Update()
        {
            Console.WriteLine("User ID");
            string UserID = Console.ReadLine();

            Console.WriteLine("User Name:");
            string Username = Console.ReadLine();

            Console.WriteLine("User Surname:");
            string Surname = Console.ReadLine();

            Console.WriteLine("User Email:");
            string Email = Console.ReadLine();

            Console.WriteLine("User Password:");
            string Password = Console.ReadLine();

            Console.WriteLine(" Department ID");
            string userDeptId = Console.ReadLine();

            Console.WriteLine(" GenderId");
            string userGenderId = Console.ReadLine();


            Console.WriteLine("usertypeid");
            string usertypeId = Console.ReadLine();

            Console.WriteLine("usertypeid");
            string StatusID = Console.ReadLine();

            var _objectUpdate = new UpdatedUser();

            _objectUpdate.UserToUpdate(Convert.ToInt16(UserID), Username, Surname, Email, Password, Convert.ToInt16(userDeptId), Convert.ToInt16(userGenderId), Convert.ToInt16(usertypeId), Convert.ToInt16(StatusID));




        }

        public void UserToUpdate(int UserID, string Username, string Surname, string Email, string Password, int userDeptId, int userGenderId, int usertypeId, int StatusID)
        {
            var db = new TableContext();
            var OrginalInfo = db.Rusers.Find(UserID);

            OrginalInfo.RegisteredUserID = UserID;
            OrginalInfo.FirstName = Username;
            OrginalInfo.LastName = Surname;
            OrginalInfo.EmailAddress = Email;
            OrginalInfo.Password = Password;
            OrginalInfo.DepartmentID = userDeptId;
            OrginalInfo.GenderID = userGenderId;
            OrginalInfo.StatusID = StatusID;
            OrginalInfo.UserTypeID = usertypeId;
            db.SaveChanges();


            Console.WriteLine("New user has been created ");
            Console.ReadKey();







        }
    }
}
