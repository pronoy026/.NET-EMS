using EMS_DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMS_DAL
{
    public static class DAL
    {
        static string connString = ConfigurationManager.ConnectionStrings["SqlConnString"].ToString();

        public static DataSet GetEmployeelist()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = "select e.Name as 'Employee Name', e.Email, e.Gender, e.DateOFBirth, e.DateOfJoining,e.Phone, " +
                        "e.Salary, e.Commission, d.FullName as 'Department', ISNULL(m.Name, 'No Manager') as Manager " +
                        "from Employees e left join Employees m on e.ReportingTo = m.Number join Departments d on e.DepartmentNo = d.DepartmentId";
                    SqlCommand command = new SqlCommand(query, connection);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    return ds;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool RegisterUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"INSERT INTO Users(Username,Password)"
                                + $"VALUES('{username}','{password}')";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public static bool LoginUser(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"select * from Users where Username = '{username}' and Password = '{password}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    if (ds.Tables[0].Rows.Count>0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }

        }


        public static DataSet GetEmployeeById(int empId)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"select * from Employees where Number={empId}";
                    SqlCommand command = new SqlCommand(query, connection);
                    DataSet ds = new DataSet();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(ds);
                    return ds;

                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool AddEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"INSERT INTO Employees (Name, Salary, Commission, DateOfJoining, DateOFBirth, DepartmentNo, JobTitle, ReportingTo, Email, Phone, Gender) " +
                                $"VALUES('{ employee.Name }', { employee.Salary }, { employee.Commission }," +
                                $"'{ employee.DateOfJoining.ToString("yyyy-MM-dd") }', '{employee.DateOfBirth.ToString("yyyy-MM-dd")}', { employee.DepartmentNo }," +
                                $"'{ employee.JobTitle }', { employee.ReportingTo }, '{ employee.Email }', { employee.Phone }, '{ employee.Gender }')";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    int result = command.ExecuteNonQuery();

                    if(result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static bool UpdateEmployee(Employee employee)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connString))
                {
                    var query = $"UPDATE Employees SET " +
                                $"Name = '{ employee.Name }', Salary = { employee.Salary }, Commission = { employee.Commission }, DateOfJoining = '{ employee.DateOfJoining.ToString("yyyy-MM-dd") }'," +
                                $"DateOFBirth = '{ employee.DateOfBirth.ToString("yyyy-MM-dd") }', DepartmentNo = { employee.DepartmentNo }, JobTitle = '{ employee.JobTitle }', ReportingTo = { employee.ReportingTo }," +
                                $"Email = '{ employee.Email }', Phone = { employee.Phone }, Gender = '{ employee.Gender }'" +
                                $" WHERE Number = {employee.Number}";

                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();

                    int result = command.ExecuteNonQuery();

                    if (result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public static DataSet GetDepartments()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("select DepartmentId, FullName from Departments",connection);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                return ds;

            }
        }

        public static DataSet GetEmployeeIdAndName()
        {
            using (SqlConnection connection = new SqlConnection(connString))
            {
                SqlCommand command = new SqlCommand("select Number, Name from Employees", connection);
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ds);
                return ds;

            }
        }
    }
}
