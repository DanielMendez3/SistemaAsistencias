namespace SistemaAsistencias.Entities
{
    public class Position
    {
        public int PositionID { get; set; }
        public string Description { get; set; }
        public decimal SalaryBasexHour { get; set; }
        public bool IsActive { get; set; }
    }
}
