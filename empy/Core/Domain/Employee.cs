namespace empy.Core.Domain
{
    public class Employee
    {
        public int Ide { get; set; }
        public string Name { get; set; }
        public string ContractTypeName { get; set; }
        public int RolId { get; set; }
        public string RolDescription { get; set; }
        public double HourlySalary { get; set; }
        public double MonthlySalary { get; set; }
    }
}