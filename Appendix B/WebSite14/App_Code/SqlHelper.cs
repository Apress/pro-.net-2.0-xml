using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public class SqlHelper
{
    private static string strConn;

    static SqlHelper()
    {
        strConn = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
    }

    public static int ExecuteNonQuery(string sql, SqlParameter[] p)
    {
        SqlConnection cnn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand(sql, cnn);
        for (int i = 0; i < p.Length; i++)
        {
            cmd.Parameters.Add(p[i]);
        }
        cnn.Open();
        int retval = cmd.ExecuteNonQuery();
        cnn.Close();
        return retval;
    }

    public static object ExecuteScalar(string sql, SqlParameter[] p)
    {
        SqlConnection cnn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand(sql, cnn);
        for (int i = 0; i < p.Length; i++)
        {
            cmd.Parameters.Add(p[i]);
        }
        cnn.Open();
        object obj = cmd.ExecuteScalar();
        cnn.Close();
        return obj;
    }

    public static DataSet GetDataSet(string sql,SqlParameter[] p)
    {
        SqlConnection cnn = new SqlConnection(strConn);
        SqlCommand cmd = new SqlCommand(sql, cnn);
        if (p != null)
        {
            for (int i = 0; i < p.Length; i++)
            {
                cmd.Parameters.Add(p[i]);
            }
        }
        SqlDataAdapter da = new SqlDataAdapter();
        da.SelectCommand = cmd;
        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }
}
