using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
public class ECommerceService : System.Web.Services.WebService
{
    [WebMethod]
    public DataSet GetProducts()
    {
        DataSet ds = SqlHelper.GetDataSet("select * from products",null);
        return ds;
    }

    [WebMethod]
    public int AddItem(string cartid,int productid,int qty)
    {
        string sql = "insert into shoppingcart(cartid,productid,qty) values(@cartid,@productid,@qty)";
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@cartid", cartid);
        p[1] = new SqlParameter("@productid", productid);
        p[2] = new SqlParameter("@qty", qty);
        return SqlHelper.ExecuteNonQuery(sql, p);
    }

    [WebMethod]
    public int UpdateItem(string cartid, int productid,int qty)
    {
        string sql = "update shoppingcart set qty=@qty where cartid=@cartid and productid=@productid";
        SqlParameter[] p = new SqlParameter[3];
        p[0] = new SqlParameter("@qty", qty);
        p[1] = new SqlParameter("@cartid", cartid);
        p[2] = new SqlParameter("@productid", productid);
        return SqlHelper.ExecuteNonQuery(sql, p);

    }

    [WebMethod]
    public int RemoveItem(string cartid, int productid)
    {
        string sql = "delete from shoppingcart where cartid=@cartid and productid=@productid";
        SqlParameter[] p = new SqlParameter[2];
        p[0] = new SqlParameter("@cartid", cartid);
        p[1] = new SqlParameter("@productid", productid);
        return SqlHelper.ExecuteNonQuery(sql, p);
    }

    [WebMethod]
    public DataSet GetCart(string cartid)
    {
        string sql = "select * from shoppingcart c,products p where c.productid=p.id and c.cartid=@cartid";
        SqlParameter[] p = new SqlParameter[1];
        p[0] = new SqlParameter("@cartid", cartid);
        DataSet ds = SqlHelper.GetDataSet(sql, p);
        return ds;
    }

    [WebMethod]
    public decimal GetCartAmount(string cartid)
    {
        string sql1 = "SELECT SUM(c.Qty * p.UnitPrice) AS Total FROM Products AS p INNER JOIN ShoppingCart AS c ON p.Id = c.ProductID WHERE c.CartID = @cartid";
        SqlParameter[] p1 = new SqlParameter[1];
        p1[0] = new SqlParameter("@cartid", cartid);
        object obj = SqlHelper.ExecuteScalar(sql1, p1);
        if (obj != DBNull.Value)
        {
            decimal amount = (decimal)obj;
            return amount;
        }
        else
        {
            return 0;
        }
    }

    [WebMethod]
    public int PlaceOrder(string cartid,string street,string city,string state,string country,string postalcode)
    {
        string sql1 = "SELECT SUM(c.Qty * p.UnitPrice) AS Total FROM Products AS p INNER JOIN ShoppingCart AS c ON p.Id = c.ProductID WHERE c.CartID = @cartid";
        SqlParameter[] p1 = new SqlParameter[1];
        p1[0] = new SqlParameter("@cartid", cartid);
        object obj=SqlHelper.ExecuteScalar(sql1, p1);
        decimal amount = (decimal)obj;

        string sql2 = "insert into orders(cartid,orderdate,amount,street,country,state,city,postalcode) values(@cartid,@orderdate,@amount,@street,@country,@state,@city,@postalcode)";
        SqlParameter[] p2 = new SqlParameter[8];
        p2[0] = new SqlParameter("@cartid", cartid);
        p2[1] = new SqlParameter("@orderdate", DateTime.Now);
        p2[2] = new SqlParameter("@amount", amount);
        p2[3] = new SqlParameter("@street", street);
        p2[4] = new SqlParameter("@country", country);
        p2[5] = new SqlParameter("@state", state);
        p2[6] = new SqlParameter("@city", city);
        p2[7] = new SqlParameter("@postalcode", postalcode);
        int i=SqlHelper.ExecuteNonQuery(sql2, p2);

        string sql3 = "insert into orderdetails(cartid,productid,qty) select cartid,productid,qty from shoppingcart where cartid=@cartid";
        SqlParameter[] p3 = new SqlParameter[1];
        p3[0] = new SqlParameter("@cartid", cartid);
        SqlHelper.ExecuteNonQuery(sql3, p3);

        string sql4 = "delete from shoppingcart where cartid=@cartid";
        SqlParameter[] p4 = new SqlParameter[1];
        p4[0] = new SqlParameter("@cartid", cartid);
        SqlHelper.ExecuteNonQuery(sql4, p4);

        return i;

        
    }

    
}
