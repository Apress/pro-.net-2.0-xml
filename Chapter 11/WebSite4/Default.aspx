<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource ID="XmlDataSource1" runat="server" DataFile="~/Navigation.xml" XPath='/node/node[@text="Products"]'></asp:XmlDataSource>
    
    </div>
        <asp:TreeView ID="TreeView1" runat="server" DataSourceID="XmlDataSource1" Font-Bold="True" Font-Size="Large">
            <DataBindings>
                <asp:TreeNodeBinding DataMember="node" NavigateUrlField="url" TextField="text" />
                <asp:TreeNodeBinding DataMember="node" NavigateUrlField="url" TextField="text" />
            </DataBindings>
        </asp:TreeView>
    </form>
</body>
</html>
