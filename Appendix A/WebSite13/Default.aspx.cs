using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using RSS;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.ContentEncoding = System.Text.Encoding.UTF8;
        Response.ContentType = "text/xml";
        RssWriter writer = new RssWriter(Response.OutputStream);
        writer.WriteStartElement(RssElements.Rss);
        writer.WriteAttributeString(RssAttributes.Version, "2.0");
        writer.WriteStartElement(RssElements.Channel);
        writer.WriteElementString(RssElements.Title, "DotNetBips.com");
        writer.WriteElementString(RssElements.Link, "http://www.dotnetbips.com");
        writer.WriteElementString(RssElements.Description, "Latest Articles from DotNetBips.com");
        writer.WriteElementString(RssElements.Copyright, "Copyright (C) DotNetBips.com. All rights reserved.");
        writer.WriteElementString(RssElements.Generator, "Pro XML RSS Generator");
        writer.WriteStartElement(RssElements.Item);
        writer.WriteElementString(RssElements.Title, "DotNetBips.com");
        writer.WriteElementString(RssElements.Link, "http://www.dotnetbips.com/Articles/displayarticle.aspx?id=242");
        writer.WriteElementString(RssElements.Description, "This article explains how to create and consume RSS feeds.");
        writer.WriteElementString(RssElements.PubDate, "Sun, 25 Jan 2004 12:00:00 AM GMT");
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.WriteEndElement();
        writer.Close();
        Response.End();
    }
}
