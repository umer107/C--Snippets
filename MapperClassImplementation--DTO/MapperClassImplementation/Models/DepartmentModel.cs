using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapperClassImplementation.Models
{
    public class DepartmentModel
    {
        public DepartmentModel()
        {
            this.employess = new List<EmployeesModel>();
        }
        public int DeptID { get; set; }
        public string DeptName { get; set; }

        public List<EmployeesModel> employess { get; set; }
    }
}