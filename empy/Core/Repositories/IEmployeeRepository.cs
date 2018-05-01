using empy.Core.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace empy.Core.Repositories
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<EmployeeApiDto>> GetEmployeesAsync();
    }
}
