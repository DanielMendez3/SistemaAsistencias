using System;

namespace SistemaAsistencias.DAL
{
    public class ConexionDB
    {
        private string ConexionString;
        public ConexionDB()
        {
            ConexionString = Environment.GetEnvironmentVariable("PLANILLACN");
        }

        public string GetConnectionString()
        {
            return ConexionString;
        }
    }
}
