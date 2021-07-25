using SistemaAsistencias.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SistemaAsistencias.DAL
{
    public class PersonalDAL
    {
        private readonly ConexionDB _conexionDB = new ConexionDB();
        public bool InsertarPersonal(Employee employee)
        {
            bool IsSuccess = false;
            try
            {
                using (SqlConnection cnx = new SqlConnection(_conexionDB.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_CreateEmployee", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@Name", employee.Name);
                        cmd.Parameters.AddWithValue("@Identifier", employee.Identificator);
                        cmd.Parameters.AddWithValue("@Country", employee.Country);
                        cmd.Parameters.AddWithValue("@Position", employee.Position.PositionID);
                        cmd.Parameters.AddWithValue("@SalaryxHour", employee.SalaryxHour);
                        cnx.Open();
                        cmd.ExecuteNonQuery();
                    }

                }

                IsSuccess = true;
                return IsSuccess;
            }
            catch (Exception)
            {

                return IsSuccess;
            }
        }

        public List<Employee> MostrarPersonal(int PageNumber, int RowspPage, string FilterString)
        {
            try
            {
                List<Employee> employees = new List<Employee>();
                using (SqlConnection cnx = new SqlConnection(_conexionDB.GetConnectionString()))
                {
                    using (SqlCommand cmd = new SqlCommand("sp_MostrarPersonal", cnx))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@PageNumber", PageNumber);
                        cmd.Parameters.AddWithValue("@RowspPage", RowspPage);
                        cmd.Parameters.AddWithValue("@Filter", FilterString);
                        cnx.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var employee = new Employee();
                                employee.EmployeeID = (int)reader["EmployeeID"];
                                employee.Name = (string)reader["Name"];
                                employee.Identificator = (string)reader["Identificator"];
                                employee.Country = (string)reader["Country"];
                                employee.Position.Description = (string)reader["PositionName"];
                                employee.SalaryxHour = (decimal)reader["SalarypHour"];
                                employee.Status.Description = (string)reader["Status"];
                                employees.Add(employee);
                            }
                        }
                    }
                }

                return employees;
            }
            catch (Exception)
            {

                return new List<Employee>();
            }
        }
    }
}
