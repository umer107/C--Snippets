//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MapperClassImplementation.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int EmpID { get; set; }
        public Nullable<int> AgeInYrs { get; set; }
        public string Name { get; set; }
        public Nullable<int> DeptID { get; set; }
    
        public virtual Department Department { get; set; }
    }
}
