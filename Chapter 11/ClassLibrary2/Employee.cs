using System;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeServer
{
    public class Employee:MarshalByRefObject
    {
        public Employee()
        {
            Console.WriteLine("Inside Employee Constructor...");
        }

        public EmployeeDetails GetEmployee(int empid)
        {
            string strConn = @"data source=.\sqlexpress;initial catalog=northwind;integrated security=true";
            EmployeeDetails emp = new EmployeeDetails();
            SqlConnection cnn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand("select employeeid,firstname,lastname,homephone,notes from employees where employeeid=@id", cnn);
            SqlParameter p = new SqlParameter("@id", empid);
            cmd.Parameters.Add(p);
            SqlDataReader reader = null;
            try
            {
                cnn.Open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    emp.EmployeeID = reader.GetInt32(0);
                    emp.FirstName = reader.GetString(1);
                    emp.LastName = reader.GetString(2);
                    emp.HomePhone = reader.GetString(3);
                    emp.Notes = reader.GetString(4);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                reader.Close();
                cnn.Close();
            }
            return emp;
        }
    }
}
