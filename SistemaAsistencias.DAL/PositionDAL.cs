using SistemaAsistencias.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAsistencias.DAL
{
    public class PositionDAL
    {
        private readonly ConexionDB _conexionDB = new ConexionDB();
        public bool InsertarCargo(Position model)
        {
            bool isSuccess = false;
            try
            {
                using (var cnx = new SqlConnection(_conexionDB.GetConnectionString()))
                {
                    using (var cmd = new SqlCommand("sp_CreatePosition", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PositionName", model.Description);
                        cmd.Parameters.AddWithValue("@SalaryxHour", model.SalaryBasexHour);
                        cnx.Open();
                        isSuccess = cmd.ExecuteNonQuery() > 0;
                    }
                }

                return isSuccess;
            }
            catch (Exception ex)
            {
                return isSuccess;
            }
        }

        public List<Position> GetPositions()
        {
            var positions = new List<Position>();
            try
            {
                using (SqlConnection cnx = new SqlConnection(_conexionDB.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("[sp_MostrarCargos]", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cnx.Open();
                        var reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var position = new Position();
                                position.PositionID = (int)reader["Id"];
                                position.Description = (string)reader["Description"];
                                position.SalaryBasexHour = (decimal)reader["SalaryxHour"];
                                positions.Add(position);
                            }
                        }
                    }
                }
                
                return positions;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
