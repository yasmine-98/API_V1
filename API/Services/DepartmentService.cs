using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Models;
using API.IServices;
using Microsoft.EntityFrameworkCore;
namespace API.Services
{
    public class DepartmentService : IDepartmentService
    {
        APICoreDBContext dbContext;
        public DepartmentService(APICoreDBContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Department> GetDepartment()
        {
            var department = dbContext.Department.ToList();
            return department;
        }
        


        public Department AddDepartment(Department department)
        {
            if (department != null)
            {
                dbContext.Department.Add(department);
                dbContext.SaveChanges();
                return department;
            }
            return null;
        }

        public Department UpdateDepartment(Department department)
        {
            dbContext.Entry(department).State = EntityState.Modified;
            dbContext.SaveChanges();
            return department;
        }

        public Department DeleteDepartment(int id)
        {
            var department = dbContext.Department.FirstOrDefault(x => x.IdDep == id);
            dbContext.Entry(department).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return department;
        }

        public Department GetDepartmentById(int id)
        {
            var department = dbContext.Department.FirstOrDefault(x => x.IdDep == id);
            return department;
        }

    }
}
