using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MapperClassImplementation.Models
{
    public class EmployeesModel
    {
        public int EmpID { get; set; }
        public Nullable<int> AgeInYrs { get; set; }
        public string EmpName { get; set; }
        public Nullable<int> DeptID { get; set; }
    }
}