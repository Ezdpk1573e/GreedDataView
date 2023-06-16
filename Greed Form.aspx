<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Greed Form.aspx.cs" Inherits="GreedDataView.Greed_Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 128%;
            height: 368px;
        }
        .auto-style2 {
            width: 285px;
        }
        .auto-style3 {
            width: 914px;
        }
        .auto-style4 {
            width: 285px;
            height: 30px;
        }
        .auto-style5 {
            width: 914px;
            height: 30px;
        }
        .auto-style6 {
            height: 31px;
        }
    </style>
</head>
<body style="width: 573px; height: 392px; margin-right: 3px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Enter Name <strong>:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox1" runat="server" Width="167px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Father Name <strong>:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox2" runat="server" Width="167px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Mother Name <strong>:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox3" runat="server" Width="167px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Address <strong>:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox4" runat="server" Width="167px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">City <strong>:</strong></td>
                <td class="auto-style3">
                    <asp:TextBox ID="TextBox5" runat="server" Width="167px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="View" BackColor="Yellow" BorderColor="Black" BorderWidth="2px" CssClass="Blue" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:GridView ID="GridView1" runat="server" Height="130px" Width="543px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
                       

                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Final Submit" BackColor="Red" BorderColor="Black" BorderWidth="2px" CssClass="Red" />
                </td>
            </tr>
        </table>
        <div class="auto-style6">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink ID="HyperLink1" runat="server" BackColor="Pink" BorderColor="Black" BorderWidth="2px" Height="26px" NavigateUrl="~/DataView.aspx" Width="111px">Full Data Show</asp:HyperLink>
        </div>
    </form>
</body>
</html>
