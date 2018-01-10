using MapperClassImplementation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Library.Core;
using Library.Core.Services;
using MapperClassImplementation.Data;

namespace MapperClassImplementation.Controllers
{
    public class HelloController : ApiController
    {
        private HellEntities hell = new HellEntities();
        public Result<List<DepartmentModel>> GetDepartments()
        {
            //string includingProperties = "Employee";
            var model = new List<DepartmentModel>();
            var data = hell.Departments.OrderBy(p => p.DeptID).ToList();
            
            if(data != null)
            {
                var mapper = new DepartmentMapper();
                foreach (var item in data)
                {
                    model.Add(mapper.MapDataModelToVm(item));
                }
            }
            
            return new Result<List<DepartmentModel>>
            {
                Data = model,
                Message = "SuccessFullyGetData",

            };

        
        
        }

    }
}
