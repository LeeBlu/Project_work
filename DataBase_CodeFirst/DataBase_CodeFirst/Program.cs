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
        TableContext db = new TableContext();
        static void Main(string[] args)
        {

            var _objInsertUser = new InsertUser();
            _objInsertUser.EnterUser();

            //var _ObjDeptINs = new AdDepartment();
            //_ObjDeptINs.AddDepart();

        }

    }
}
