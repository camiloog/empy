using System.Configuration;
using empy.Core.Domain;
using empy.Core.Repositories;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace empy.Persistence.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private static string ApiUrl = ConfigurationManager.AppSettings["EmployeesApiUrl"];

        public async Task<IEnumerable<Employee>> GetEmployeesAsync()
        {    
            var employeesJson = await GetStringAsync(ApiUrl);
            return new JavaScriptSerializer().Deserialize<List<Employee>>(employeesJson);
        }

        private static async Task<string> GetStringAsync(string url)
        {
            using (var httpClient = new HttpClient())
            {
                return await httpClient.GetStringAsync(url);
            }
        }
    }
}
