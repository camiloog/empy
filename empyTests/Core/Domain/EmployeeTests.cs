using Microsoft.VisualStudio.TestTools.UnitTesting;
using empy.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empy.Core.Domain.Tests
{
    [TestClass()]
    public class EmployeeTests
    {
        [TestMethod()]
        public void EmployeeTest_HourlySalaryEmployee()
        {
            var rawEmployee = new EmployeeApiDto();
            rawEmployee.ContractTypeName = "HourlySalaryEmployee";
            rawEmployee.HourlySalary = 60000;
            rawEmployee.MonthlySalary = 80000;
            var employee = new Employee(rawEmployee);
            Assert.AreEqual(employee.AnnualSalary, 120.0 * rawEmployee.HourlySalary * 12.0);
        }

        [TestMethod()]
        public void EmployeeTest_MonthlySalaryEmployee()
        {
            var rawEmployee = new EmployeeApiDto();
            rawEmployee.ContractTypeName = "MonthlySalaryEmployee";
            rawEmployee.HourlySalary = 60000;
            rawEmployee.MonthlySalary = 80000;
            var employee = new Employee(rawEmployee);
            Assert.AreEqual(employee.AnnualSalary, rawEmployee.MonthlySalary * 12.0);
        }
    }
}