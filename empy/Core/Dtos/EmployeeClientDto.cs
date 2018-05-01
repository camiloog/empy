using empy.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace empy.Core.Dtos
{
    public class EmployeeClientDto
    {
        public EmployeeClientDto(EmployeeApiDto employee)
        {
            Employee _employee = new Employee(employee);
            Id = _employee.Id;
            Name = _employee.Name;
            ContractTypeName = _employee.ContractTypeName;
            RoleName = _employee.RoleName;
            HourlySalary = _employee.HourlySalary;
            MonthlySalary = _employee.MonthlySalary;
            AnnualSalary = _employee.AnnualSalary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public string RoleName { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
        public double AnnualSalary { get; set; }
    }
}