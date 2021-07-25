using SistemaAsistencias.DAL;
using SistemaAsistencias.Entities;
using System.Collections.Generic;

namespace SistemaAsistencias.BLO
{
    public class PositionBLO
    {
        private readonly PositionDAL _positionDAL = new PositionDAL();
        public (bool, string) InsertarCargo(Position model)
        {
            string message;
            bool isSuccess;
            //Validaciones
            (isSuccess, message) = IsValid(model);
            if (!isSuccess)
                return (isSuccess, message);

            isSuccess = _positionDAL.InsertarCargo(model);
            if (isSuccess)
                return (isSuccess, "REGISTRO EXITOSO.");

            return (isSuccess, "OCURRIÓ UN PROBLEMA AL CREAR EL NUEVO CARGO");
        }

        public List<Position> GetPositions()
        {
            return _positionDAL.GetPositions();
        }

        //Helpers
        public (bool, string) IsValid(Position model)
        {
            bool isSuccess = false;
            string message = "";

            if (string.IsNullOrEmpty(model.Description))
            {
                message = "LA DESCRIPCIÓN NO PUEDE ESTAR VACÍA";
                return (isSuccess, message);
            }

            if (model.SalaryBasexHour <= 0)
            {
                message = "EL SALARIO POR HORA DEBE SER MAYOR A 0";
                return (isSuccess, message);
            }

            isSuccess = true;

            return (isSuccess, message);
        }
    }
}
