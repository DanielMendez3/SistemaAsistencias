namespace SistemaAsistencias.BLO
{
    public static class Helpers
    {
        public static bool IsDecimal(string value)
        {
            if (double.TryParse(value, out double result))
                return true;

            return false;
        }
    }
}
