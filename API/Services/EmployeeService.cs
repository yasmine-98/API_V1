using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.IServices;
using API.Models;
//using LinqJoin;

namespace API.Services
{
    public class EmployeeService : IEmployeeService
    {
        APICoreDBContext dbContext;
        public EmployeeService(APICoreDBContext _db)
        {
            dbContext = _db;
        }

        public IEnumerable<Employee> GetEmployee()
        {
            var employee = dbContext.Employee.ToList();
            return employee;
        }


        public Employee AddEmployee(Employee employee)
        {
            if (employee != null)
            {
                dbContext.Employee.Add(employee);
                dbContext.SaveChanges();
                return employee;
            }
            return null;
        }

        public Employee UpdateEmployee(Employee employee)
        {
            dbContext.Entry(employee).State = EntityState.Modified;
            dbContext.SaveChanges();
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            var employee = dbContext.Employee.FirstOrDefault(x => x.Id == id);
            dbContext.Entry(employee).State = EntityState.Deleted;
            dbContext.SaveChanges();
            return employee;
        }

        public Employee GetEmployeeById(int id)
        {
            var employee = dbContext.Employee.FirstOrDefault(x => x.Id == id);
            return employee;
        }

        public void  JoinMethode()
        {
            var innerJoinQuery =
                from E in Employee
                join D in Department on E.Id equals D.IdDep
                select new { E.Name };

            Console.WriteLine("InnerJoin:");
            // Execute the query. Access results
            // with a simple foreach statement.
            foreach (var item in innerJoinQuery)
            {
                Console.WriteLine($"{item.Department} - {item.Employee}");
            }
           
        }

    }
}

