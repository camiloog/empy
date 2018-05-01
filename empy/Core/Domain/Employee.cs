using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace empy.Core.Domain
{
    public delegate double AnnualSalaryCalculator();  

    public class Employee
    {
        public Employee(EmployeeApiDto employee)
        {            
            Id = employee.Id;
            Name = employee.Name;
            ContractTypeName = employee.ContractTypeName;
            RoleId = employee.RoleId;
            RoleName = employee.RoleName;
            RoleDescription = employee.RoleDescription;
            HourlySalary = employee.HourlySalary;
            MonthlySalary = employee.MonthlySalary;
            Factorize();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }

        public double AnnualSalary
        {
            get { return SalaryCalculator(); }
        }

        private double HourlySalaryEmployeeAnnualSalary()
        {
            return 120 * HourlySalary * 12;
        }

        private double MonthlySalaryEmployeeAnnualSalary()
        {
            return MonthlySalary * 12;
        }

        private AnnualSalaryCalculator SalaryCalculator;

        private void Factorize()
        {
            // Magic Strings to fix
            if (ContractTypeName == "HourlySalaryEmployee")
                SalaryCalculator = HourlySalaryEmployeeAnnualSalary;
            else if (ContractTypeName == "MonthlySalaryEmployee")
                SalaryCalculator = MonthlySalaryEmployeeAnnualSalary;
            else
                throw new Exception("Invalid Contract Type");
        }
    }    
}