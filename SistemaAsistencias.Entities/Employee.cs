namespace SistemaAsistencias.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Identificator { get; set; }
        public string Country { get; set; }
        public Position Position { get; set; }
        public decimal SalaryxHour { get; set; }
        public StatusEmployee Status { get; set; }

        public Employee()
        {
            this.Position = new Position();
            this.Status = new StatusEmployee();
        }
    }
}
