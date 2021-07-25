using SistemaAsistencias.DAL;
using SistemaAsistencias.Entities;
using System.Collections.Generic;

namespace SistemaAsistencias.BLO
{
    public class PersonalBLO
    {
        private readonly PersonalDAL _personalDAL = new PersonalDAL();
        public (bool, string) InsertarPersonal(Employee employee)
        {
            string message;
            bool isSuccess;

            (isSuccess, message) = IsValid(employee);

            if (!isSuccess)
                return (isSuccess, message);

            isSuccess =  _personalDAL.InsertarPersonal(employee);
            if (isSuccess)
                return (isSuccess, "SE REGISTRÓ CORRECTAMENTE.");

            return (isSuccess, "OCURRIÓ UN PROBLEMA AL CREAR EL NUEVO REGISTRO");
        }

        public List<Employee> MostrarPersonal(int PageNumber = 1, int RowspPage = 10, string FilterString = "")
        {
            return _personalDAL.MostrarPersonal(PageNumber, RowspPage, FilterString);
        }

        //Helpers
        public (bool, string) IsValid(Employee model)
        {
            bool isSuccess = false;
            string message = "";

            if (string.IsNullOrEmpty(model.Name))
            {
                message = "EL NOMBRE NO PUEDE ESTAR VACÍO";
                return (isSuccess, message);
            }

            if (model.Position == null)
            {
                message = "EL VALOR DEL CARGO NO PUEDE ESTAR VACÍO";
                return (isSuccess, message);
            }

            if (model.Position.PositionID == 0)
            {
                message = "DEBE SELECCIONAR UN CARGO VÁLIDO";
                return (isSuccess, message);
            }

            if (string.IsNullOrEmpty(model.Country))
            {
                message = "EL PAÍS NO PUEDE ESTAR VACÍO";
                return (isSuccess, message);
            }

            if (model.SalaryxHour <= 0)
            {
                message = "EL SALARIO POR HORA DEBE SER MAYOR A 0";
                return (isSuccess, message);
            }

            isSuccess = true;

            return (isSuccess, message);
        }
    }
}
