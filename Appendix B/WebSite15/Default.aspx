<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large"
            Text="Product Catalog"></asp:Label><br />
        <hr />
        <br />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" DataKeyNames="Id" Width="341px">
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Products">
                    <ItemTemplate>
                        <table style="width: 100%">
                            <tr>
                                <td nowrap="noWrap">
                                    <asp:Label ID="Label2" runat="server" Font-Bold="True" Text='<%# Eval("Name") %>' Font-Size="Large"></asp:Label></td>
                            </tr>
                            <tr>
                                <td style="height: 21px">
                                    <asp:Label ID="Label3" runat="server" Text='<%# Eval("Description") %>'></asp:Label></td>
                            </tr>
                            <tr>
                                <td nowrap="noWrap">
                                    <asp:Label ID="Label5" runat="server" Font-Bold="True" Text="Price :"></asp:Label>
                                    <asp:Label ID="Label4" runat="server" Text='<%# Eval("UnitPrice","{0:C}") %>' Font-Bold="True"></asp:Label></td>
                            </tr>
                            <tr>
                                <td nowrap="nowrap">
                                    <asp:Button ID="Button1" runat="server" CommandArgument='<%# Eval("Id") %>' CommandName="Select"
                                        Text="Add To Cart" /></td>
                            </tr>
                        </table>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        &nbsp;</div>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetProducts"
            TypeName="localhost.ShoppingCartService"></asp:ObjectDataSource>
        <br />
        &nbsp;<asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/ShoppingCart.aspx">Go To Shopping Cart</asp:HyperLink>
    </form>
</body>
</html>
