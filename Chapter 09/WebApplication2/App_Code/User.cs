using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Web.Services.Protocols;

public class User:SoapHeader
{
    private string strUid;
    private string strPwd;

    public string UserID
    {
        get
        {
            return strUid;
        }
        set
        {
            strUid=value;
        }
    }

    public string Password
    {
        get
        {
            return strPwd;
        }
        set
        {
            strPwd = value;
        }
    }
}
