using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string[] roles=Roles.GetRolesForUser();
        Label2.Text = "Your are registered as " + string.Join(",", roles);
        if (!IsPostBack)
        {
            GetProfile();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        SetProfile();
    }

    private void SetProfile()
    {
        Profile.FullName = TextBox1.Text;
        Profile.DOB = DateTime.Parse(TextBox2.Text);
        Profile.Address.Street = TextBox3.Text;
        Profile.Address.State = TextBox4.Text;
        Profile.Address.Country = TextBox5.Text;
        Profile.Address.PostalCode = TextBox6.Text;
    }

    private void GetProfile()
    {
        if (Profile.FullName != "")
        {
            TextBox1.Text = Profile.FullName;
            TextBox2.Text = Profile.DOB.ToShortDateString();
            TextBox3.Text = Profile.Address.Street;
            TextBox4.Text = Profile.Address.State;
            TextBox5.Text = Profile.Address.Country;
            TextBox6.Text = Profile.Address.PostalCode;
        }
    }
}
