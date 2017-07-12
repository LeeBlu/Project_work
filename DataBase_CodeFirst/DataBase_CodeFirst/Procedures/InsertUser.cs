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
    class InsertUser
    {
        public void EnterUser()
        {

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

            Console.WriteLine("StatusID");
            string StatusID = Console.ReadLine();


            var _objInserUser = new InsertUser();
            _objInserUser.InsertUserInfomation(Username, Surname, Email, Password, Convert.ToInt16(userDeptId), Convert.ToInt16(userGenderId), Convert.ToInt16(usertypeId), Convert.ToInt16(StatusID));





        }
        public void InsertUserInfomation(string Username, string Surname, string Email, string Password, int userDeptId, int userGenderId, int usertypeId, int StatusID)
        {
            using (var objTableContext = new TableContext())
            {
                //try
                //{
                var _objAddUser = new RegisteredUser
                {

                    IsDeleted = false,
                    FirstName = Username,
                    LastName = Surname,
                    EmailAddress = Email,
                    Password = Password,
                    DepartmentID = userDeptId,
                    GenderID = userGenderId,
                    UserTypeID = usertypeId,
                    StatusID = StatusID


                };

                objTableContext.Rusers.Add(_objAddUser);
                objTableContext.SaveChanges();
                Console.WriteLine("New user has been created ");
                Console.ReadKey();


                //    }
                //        catch (Exception)
                //    {

                //        Console.WriteLine("Could not create user ");
                //    }

            }
        }
    }
}
