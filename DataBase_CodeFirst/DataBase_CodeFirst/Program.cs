using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer_2.ContextFolder;
using System.Data.Entity;
using DataBase_CodeFirst;
using DataLayer_2.Model;
using DataBase_CodeFirst.Procedures;


namespace DataBase_CodeFirst
{

    
    class Program
    { 
        // instantiate Classes
         static public UserOperations userOps = new UserOperations();
         static public AddressOperations addressOps = new AddressOperations();
         static public RegisteredUser user = new RegisteredUser();
         static public Address addr = new Address();

      
        static void Main(string[] args)
        {
            int gid, depid,addtype,userid;

            //Output Instructions for User 
            Console.WriteLine("Register ...press 1");
            Console.WriteLine("Add address to your profile... press 2 ");
            Console.WriteLine("Update your information...press 3");
            Console.WriteLine("Update address... press 4");

            //Input from user
            var op = Convert.ToInt16(Console.ReadLine());

           
            if (op==1)//Enter Registation information
            {

                Console.WriteLine("Enter Firstname");
                user.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Lastname");
                user.LastName = Console.ReadLine();
                Console.WriteLine("Enter email");
                user.EmailAddress = Console.ReadLine();
                Console.WriteLine("Enter Password");
                user.Password = Console.ReadLine();

                Console.WriteLine("Enter gender... press 1 for Male/... press 2 for Female");
                gid = Convert.ToInt16(Console.ReadLine());
            
                
                Console.WriteLine("Enter deparment ...press 1 for GMIC /press 2 for GMOB /press 3 for GQA");
                depid=Convert.ToInt16( Console.ReadLine());

                Console.WriteLine(userOps.AddUser(user,depid,gid));
            }

            else if (op==2)//Enter Address information
            {
                Console.WriteLine("Enter UnitNumber");
                addr.UnitNumber = Console.ReadLine();
                Console.WriteLine("Enter StreetName");
                addr.StreetName = Console.ReadLine();
                Console.WriteLine("Enter ComplexNumber");
                addr.ComplexNumber = Console.ReadLine();
              
                Console.WriteLine("Enter UserId");
                addr.RegisteredUserID = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter address typeid..press 1 for physcal address.. press 2 for postal address");
                addtype=Convert.ToInt16(Console.ReadLine());

               Console.WriteLine(addressOps.InsertAddress(addr,addr.RegisteredUserID, addtype, 1));
            }
            else if (op==3)//Enter update user Information 
            {
                Console.WriteLine("Enter userid");
                userid=Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter Firstname");
                user.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Lastname");
                user.LastName = Console.ReadLine();
                Console.WriteLine("Enter email");
                user.EmailAddress = Console.ReadLine();
                Console.WriteLine("Enter Password");
                user.Password = Console.ReadLine();

                Console.WriteLine(userOps.UpdateUser(userid,user));
            }
            else if (op==4)//Enter update address information
            {
                Console.WriteLine("Enter userid");
                userid = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Enter UnitNumber");
                addr.UnitNumber = Console.ReadLine();
                Console.WriteLine("Enter StreetName");
                addr.StreetName = Console.ReadLine();
                Console.WriteLine("Enter ComplexNumber");
                addr.ComplexNumber = Console.ReadLine();

                Console.WriteLine("Enter UserId");
                addr.RegisteredUserID = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Enter address typeid..press 1 for physcal address.. press 2 for postal address");
                addtype = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine(addressOps.UpdateAddress(userid,addr));
            }
            else if(op==5)
            {
                userOps.UserInfo();
            }
            Console.ReadKey();
            
        }

    }
}
