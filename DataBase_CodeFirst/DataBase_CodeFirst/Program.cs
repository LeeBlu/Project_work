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
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Department name");
            d.DepartmentName = Console.ReadLine();
            Console.WriteLine("Enter department description");
            d.DepartmentDescrption = Console.ReadLine();
           
            Console.WriteLine(p.InsertDepartment(d));
            Console.ReadKey(); 
        }

    }
}
