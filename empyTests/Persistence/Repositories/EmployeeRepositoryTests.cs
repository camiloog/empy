using Microsoft.VisualStudio.TestTools.UnitTesting;
using empy.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using empy.Core.Domain;

namespace empy.Persistence.Repositories.Tests
{
    [TestClass()]
    public class EmployeeRepositoryTests
    {
        [TestMethod()]
        public async Task GetEmployeesAsyncTest()
        {
            EmployeeRepository repository = new EmployeeRepository();
            var result = await repository.GetEmployeesAsync();
            Assert.IsInstanceOfType(result, typeof(IEnumerable<Employee>));
        }
    }
}