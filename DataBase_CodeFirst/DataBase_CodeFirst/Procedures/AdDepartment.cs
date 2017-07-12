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
    class AdDepartment
    {
        public void AddDepart()
        {
            Console.WriteLine("Department Name:");
            string DepartmentName = Console.ReadLine();

            Console.WriteLine("Department Description:");
            string DepartmentDescription = Console.ReadLine();

            var _ObjDeptINs = new AdDepartment();

            _ObjDeptINs.InserDptInfo(DepartmentName, DepartmentDescription);

        }

        public void InserDptInfo(string DepartmentName, string DepartmentDescription)
        {
            var _Objdept = new Department
            {
                DepartmentName = DepartmentName,
                DepartmentDescrption = DepartmentDescription

            };

            using (var _ObJTableContex = new TableContext())
            {
                //try
                //{


                _ObJTableContex.departments.Add(_Objdept);
                _ObJTableContex.SaveChanges();
                Console.WriteLine("department Created");
                Console.ReadKey();

                //}
                //catch (Exception)
                //{

                //    Console.WriteLine("department not created ");
                //    Console.ReadKey();
                //}
            }
        }


        }

    }
