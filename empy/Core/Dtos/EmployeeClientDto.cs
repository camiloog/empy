using empy.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        [DisplayName("ID")]
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Contract Type")]
        public string ContractTypeName { get; set; }
        [DisplayName("Role")]
        public string RoleName { get; set; }
        [DisplayName("Hourly Salary")]
        public double HourlySalary { get; set; }
        [DisplayName("Monthly Salary")]
        public double MonthlySalary { get; set; }
        [DisplayName("Annual Salary")]
        public double AnnualSalary { get; set; }
    }
}