using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.Core.Services;
using MapperClassImplementation.Data;

namespace MapperClassImplementation.Models
{
    //IMapper<Source,Destination>
    public class DepartmentMapper : IMapper<Department,DepartmentModel>
    {
        //Data Model to Custom Model
        public DepartmentModel MapDataModelToVm(Department source)
        {
            var target = new DepartmentModel();

            target.DeptID = source.DeptID;
            target.DeptName = source.DeptName;


            if(source.Employees != null  && source.Employees.Count > 0)
            {

                foreach (var item in source.Employees)
                {

                    target.employess.Add(new EmployeesModel()
                    {

                        DeptID = item.DeptID,
                        EmpName = item.Name,
                        EmpID = item.EmpID,
                        AgeInYrs = item.AgeInYrs


                    });

                }
            
            }

            return target;
        
        }

        //Custom Model To DataModel
        public Department MapVmToDataModel(DepartmentModel source)
        {

            var target = new Department();

            target.DeptID = source.DeptID;
            target.DeptName = source.DeptName;

            if (source.employess != null && source.employess.Count > 0)
            {

                foreach (var item in source.employess)
                {
                    //TODO: Add mappers for child tables after discussion
                    target.Employees.Add(new Employee()
                    {
                        DeptID = item.DeptID,
                        EmpID = item.EmpID,
                        Name = item.EmpName,
                        AgeInYrs = item.AgeInYrs

                    });
                }
            
            }

            return target;
        
        }


    }
}