using System;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.EnterpriseServices;

[WebService(Namespace = "http://tempuri.org/")]
public class Service : System.Web.Services.WebService
{
    [WebMethod(BufferResponse=true)]
    public string HelloWorld()
    {
        return "Hello World";
    }

    
    [WebMethod(MessageName="HelloWorldAgain")]
    public string HelloWorld(string name) 
    {
        return "Hello " + name;
    }

    [WebMethod(BufferResponse = true)]
    public string BufferMyResponse()
    {
        return "Hello World";
    }

    [WebMethod(CacheDuration = 30)]
    public string CacheMe(string name)
    {
        return "Hello " + name;
    }

    [WebMethod(EnableSession=true)]
    public void PutNameInSession(string name)
    {
        Session["myname"] = name;
    }

    [WebMethod(EnableSession = true)]
    public string GetNameFromSession()
    {
        return Session["myname"].ToString();
    }

    [WebMethod(TransactionOption = TransactionOption.Required)]
    public void ExecuteMeInTransaction()
    {
        //some code requiring transaction
    }

    [WebMethod(Description = "This is description for web method")]
    public string DescribeMe()
    {
        return "Hello World";
    }

    [WebMethod]
    public DataSet GetEmployees()
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("select * from employees", "data source=.\\sqlexpress;initial catalog=northwind;Integrated Security=True");
        da.Fill(ds, "myemployees");
        return ds;
    }

    [WebMethod]
    public Employee GetEmployee()
    {
        Employee emp = new Employee();
        emp.EmployeeID = 1;
        emp.FirstName = "Nancy";
        emp.LastName = "Davolio";
        emp.HomePhone = "(206) 555-9857";
        emp.Notes = "Notes go here";
        return emp;
    }


}
