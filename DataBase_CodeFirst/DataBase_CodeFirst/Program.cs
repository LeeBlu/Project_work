using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer_2.ContextFolder;
using DataLayer_2.Model;
using DataBase_CodeFirst.Operations;

namespace DataBase_CodeFirst
{
    class Program
    {
        static DepartmentsOps p = new DepartmentsOps();
        static Department d = new Department();
        static RegisteredUser us = new RegisteredUser();
        static UserOps usp = new UserOps();
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter  name");
            //us.FirstName = Console.ReadLine();
            //Console.WriteLine("Enter  surname");
            //us.LastName = Console.ReadLine();
            //Console.WriteLine("Enter email");
            //us.EmailAddress = Console.ReadLine();
            //Console.WriteLine("Enter password");
            //us.Password =Console.ReadLine();


            // d.DepartmentDescrption = Console.ReadLine();
           
            Console.WriteLine(usp.DeleteUser(1));
            Console.ReadKey(); 
        }

    }
}
