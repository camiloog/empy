using empy.Core.Dtos;
using empy.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace empy.Controllers.Api
{
    public class EmployeesController : ApiController
    {
        private EmployeeRepository employeeRepository = new EmployeeRepository();
        

        // GET: api/Employees
        public async Task<IHttpActionResult> Get()
        {
            var employees = await employeeRepository.GetEmployeesAsync();
            if (employees == null)
                return NotFound();
            List<EmployeeClientDto> clientEmployees = new List<EmployeeClientDto>();
            foreach (var employee in employees)
            {
                clientEmployees.Add(new EmployeeClientDto(employee));
            }
            return Ok(clientEmployees);
        }

        // GET: api/Employees/5
        public async Task<IHttpActionResult> Get(int id)
        {
            var employees = await employeeRepository.GetEmployeesAsync();
            if (employees == null)
                return NotFound();
            else if (!employees.Any(x => x.Id == id))
                return NotFound();
            else
            {
                EmployeeClientDto clientEmployee = new EmployeeClientDto(
                    employees.FirstOrDefault(y => y.Id == id)
                );
                return Ok(clientEmployee);
            }
        }
    }
}
