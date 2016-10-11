using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using localhost;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["cartid"] == null)
        {
            Session["cartid"]= Guid.NewGuid().ToString();
        }
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        ECommerceService proxy = new ECommerceService();
        proxy.AddItem(Session["cartid"].ToString(),Convert.ToInt32(GridView1.SelectedValue), 1);
    }
}
