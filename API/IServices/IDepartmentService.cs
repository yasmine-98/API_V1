using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
namespace API.IServices
{
    public interface IDepartmentService
    {
        IEnumerable<Department> GetDepartment();
        Department GetDepartmentById(int IdDep);
        Department AddDepartment(Department department);
        Department UpdateDepartment(Department department);
        Department DeleteDepartment(int IdDep);
    }
}
