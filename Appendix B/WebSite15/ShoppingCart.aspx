<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="ShoppingCart" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="X-Large"
            Text="Shopping Cart"></asp:Label>
        <hr />
    
    </div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4"
            DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" OnRowCommand="GridView1_RowCommand">
            <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <Columns>
                <asp:BoundField DataField="productid" HeaderText="Product ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="UnitPrice" DataFormatString="{0:c}" HeaderText="Unit Price" />
                <asp:TemplateField HeaderText="Qty">
                    <EditItemTemplate>
                        <asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Qty") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <ItemTemplate>
                        <asp:TextBox ID="TextBox2" runat="server" Columns="2" Text='<%# Bind("Qty") %>'></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:ButtonField CommandName="UpdateItem" Text="Update" />
                <asp:ButtonField CommandName="RemoveItem" Text="Remove" />
            </Columns>
            <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
            <EmptyDataTemplate>
                <asp:Label ID="Label2" runat="server" Font-Bold="True" ForeColor="Red" Text="Your shopping cart is empty"></asp:Label>
            </EmptyDataTemplate>
            <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
            <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCart"
            TypeName="localhost.ShoppingCartService">
            <SelectParameters>
                <asp:SessionParameter Name="cartid" SessionField="cartid" Type="String" />
            </SelectParameters>
        </asp:ObjectDataSource>
        <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="Large" Text="Total Amount :"></asp:Label>
        <asp:Label ID="Label3" runat="server"></asp:Label><br />
        <br />
        <asp:HyperLink ID="HyperLink1" runat="server" Font-Bold="True" NavigateUrl="~/Default.aspx">Shop More</asp:HyperLink><br />
        <asp:Panel ID="panel1" runat=server>
        <br />
        <asp:Label ID="Label5" runat="server" Font-Bold="True" Font-Names="Arial" Font-Size="Large"
            Text="Shipping Address"></asp:Label><br />
        <br />
        <table>
            <tr>
                <td style="width: 100px" valign="top">
                    <asp:Label ID="Label6" runat="server" Text="Street :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label7" runat="server" Text="City :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label8" runat="server" Text="State :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label9" runat="server" Text="Country :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 100px">
                    <asp:Label ID="Label10" runat="server" Text="Postal Code :"></asp:Label></td>
                <td style="width: 100px">
                    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Place Order" />
        </asp:Panel>
        <br />
        <br />
        <br />
    </form>
</body>
</html>
