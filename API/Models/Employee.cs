using System;
using System.Collections.Generic;

namespace API.Models
{
    public partial class Employee
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public int IdDepartment { get; set; }
        public decimal? Salary { get; set; }
    }
}
