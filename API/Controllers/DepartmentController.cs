using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using API.IServices;
using API.Models;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {

        private readonly IDepartmentService departmentService;
        public DepartmentController(IDepartmentService department)
        {
            departmentService = department;
        }


        [HttpGet]
        [Route("[action]")]
        [Route("api/Department/GetDepartment")]
        public IEnumerable<Department> GetDepartment()
        {
            return departmentService.GetDepartment();
        }

        [HttpPost]
        [Route("[action]")]
        [Route("api/Department/AddDepartment")]
        public Department AddDepartment(Department department)
        {
            return departmentService.AddDepartment(department);
        }

        [HttpPut]
        [Route("[action]")]
        [Route("api/Department/EditDepartment")]
        public Department EditDepartment(Department department)
        {
            return departmentService.UpdateDepartment(department);
        }

        [HttpDelete]
        [Route("[action]")]
        [Route("api/Department/DeleteDepartment")]
        public Department DeleteDepartment(int id)
        {
            return departmentService.DeleteDepartment(id);
        }

        [HttpGet]
        [Route("[action]")]
        [Route("api/Department/GetDepartmentId")]
        public Department GetDepartmentId(int id)
        {
            return departmentService.GetDepartmentById(id);
        }

        
    }
}
