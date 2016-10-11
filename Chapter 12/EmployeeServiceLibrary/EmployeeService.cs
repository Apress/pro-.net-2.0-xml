using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace EmployeeLibrary
{
    public class EmployeeService:IEmployeeService
    {

        public DataSet GetEmployees()
        {
            SqlDataAdapter da = new SqlDataAdapter("select employeeid,firstname,lastname from employees", @"data source=.\sqlexpress;initial catalog=northwind1;integrated security=true");
            DataSet ds = new DataSet();
            da.Fill(ds,"employees");
            return ds;
        }

        public Employee GetEmployee(int id)
        {
            SqlConnection cnn = new SqlConnection(@"data source=.\sqlexpress;initial catalog=northwind1;integrated security=true");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "select employeeid,firstname,lastname from employees where employeeid=@id";
            SqlParameter p = new SqlParameter("@id", id);
            cmd.Parameters.Add(p);
            cnn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Employee emp = new Employee();
            while (reader.Read())
            {
                emp.EmployeeID = reader.GetInt32(0);
                emp.FirstName = reader.GetString(1);
                emp.LastName= reader.GetString(2);
            }
            reader.Close();
            cnn.Close();
            return emp;
        }

    }
}
