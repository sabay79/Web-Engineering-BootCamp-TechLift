<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Demo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <form id="form1">
        <h6 style="color:white; font-size:medium; font-weight: bolder;">Hello</h6>

        <table class="table" style="color:black;margin-top:25px" >
            <tr style="background-color:#f0ad4e; color:white; font-weight:bold">
                <td>Product Name</td>
                <td>Brand Name</td>
                <td>Warrenty</td>
                <td>Price</td>
            </tr>
            <tr style="color:black">
                <td> 
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
                </td>
                <td> 
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr style="color:black">
                <td></td>
                <td></td> 
                <td></td>
                <td style="float:right"> 
                    <asp:Button  class="btn btn-warning" ID="AddProduct" runat="server" Text="Add Product" 
                        onclick="AddProduct_Click"/>
                </td>
            </tr>
        </table>  
        
        <div style="margin-top:20px">
            <asp:GridView class="table" ID="GridView1" AutoGenerateColumns="false" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:BoundField  HeaderStyle-Width="120px" HeaderText="Product Name" DataField="ProductName"/>
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Brand Name" DataField="BrandName"/>
                    <asp:BoundField HeaderStyle-Width="120px" HeaderText="Warrenty" DataField="Warrenty"/>
                    <asp:BoundField  HeaderStyle-Width="120px" HeaderText="Price" DataField="Price"/>
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5cb85c" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
        </div>
        <div style="margin-top:10px; float:right">
            <asp:Button class="btn btn-success" ID="btnsubmitProducts" runat="server"
                Text="Save Products" onclick="btnsubmitProducts_Click" />
        </div>
    </form>
</asp:Content>
