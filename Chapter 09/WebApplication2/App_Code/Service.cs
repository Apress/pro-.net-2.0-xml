using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class Service : System.Web.Services.WebService
{
    public User CurrentUser;

    [WebMethod]
    [SoapHeader("CurrentUser",Direction=SoapHeaderDirection.In,Required=true)]
    public DataSet GetEmployees()
    {
        if (CurrentUser == null)
        {
            throw new SoapHeaderException("Authentication details not found!",SoapException.ClientFaultCode);
        }
        if (CurrentUser.UserID == "Admin" && CurrentUser.Password == "password")
        {
            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter("select * from employees", "data source=.\\sqlexpress;initial catalog=northwind;Integrated Security=True");
            da.Fill(ds, "myemployees");
            return ds;
        }
        else
        {
            throw new SoapException("Authentication failed!",SoapException.ClientFaultCode);
        }
    }
  
}
