using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using localhost;

public partial class ShoppingCart : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            DisplayTotal();
        }

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        ECommerceService proxy = new ECommerceService();
        GridViewRow row = GridView1.Rows[Convert.ToInt32(e.CommandArgument)];

        int productid = Convert.ToInt32(row.Cells[0].Text);

        if (e.CommandName == "RemoveItem")
        {
            proxy.RemoveItem(Session["cartid"].ToString(),productid);
        }
        if (e.CommandName == "UpdateItem")
        {
            int qty = Convert.ToInt32(((TextBox)row.FindControl("TextBox2")).Text);
            if (qty <= 0)
            {
                throw new Exception("Quantity must be greater than 0");
            }
            proxy.UpdateItem(Session["cartid"].ToString(),productid,qty);
        }
        GridView1.DataBind();
        DisplayTotal();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        ECommerceService proxy = new ECommerceService();
        proxy.PlaceOrder(Session["cartid"].ToString(), TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text);
        Response.Redirect("success.aspx");
    }

    private void DisplayTotal()
    {
        ECommerceService proxy = new ECommerceService();
        decimal total=proxy.GetCartAmount(Session["cartid"].ToString());
        if (total == 0)
        {
            panel1.Visible = false;
        }
        Label3.Text = "$" + total ;
    }
}
