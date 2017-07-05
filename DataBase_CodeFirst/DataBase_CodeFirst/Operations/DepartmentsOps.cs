using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer_2.ContextFolder;
using DataLayer_2.Model;

namespace DataBase_CodeFirst.Operations
{
    class DepartmentsOps
    {
        public string InsertDepartment(Department dep)
        {
            using (var db =new TableContext())
            {
                
                db.department.Add(dep);
                db.SaveChanges();
            }

            return "department was added";
        }

        public Department GetDepInfo(int id)
        {
            using (var db =new TableContext())
            {
                var temp = db.department.Where(s => s.DepartmentID == id).FirstOrDefault();

                return temp;
            }
        }

        public string DeleteDepartment(int id)
        {
            using (var db =new TableContext())
            {
                var tempdep = db.department.Find(id);
                db.department.Remove(tempdep);
                db.SaveChanges();
                return "Department was deleted";
            }
        }

        public string UpdateDepartment(int id, Department dep)
        {
            using (var db =new TableContext())
            {

                var tempDep = db.department.Find(id);
                
                if (tempDep != null)
                {
                    tempDep = dep;
                    db.Entry(tempDep).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }


                return "department was updated";
            }
        }
    }
}
