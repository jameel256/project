<%@ Page Title="" Language="C#" MasterPageFile="~/ClientMST.Master" AutoEventWireup="true" CodeBehind="client.aspx.cs" Inherits="Mtn_Uganda_ver_1._0.client" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        color: #0000FF;
    }
    .auto-style8 {
        height: 26px;
    }
    .auto-style9 {
        width: 395px;
    }
    .auto-style10 {
        height: 26px;
        width: 395px;
        text-align: right;
    }
    .auto-style11 {
        width: 395px;
        text-align: right;
    }
        .auto-style12 {
            color: #FF3300;
        }
        .auto-style13 {
            height: 35px;
        }
        .auto-style14 {
            width: 395px;
            text-align: right;
            height: 35px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style7" colspan="7"><strong>MTN CLIENT ONLINE REGISTRATION</strong></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">Reg No.</td>
        <td style="margin-left: 40px">
            <asp:TextBox ID="a" runat="server" Height="25px" Width="307px" CssClass="auto-style7"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="a" CssClass="auto-style12" ErrorMessage="Enter only Characters required" ValidationExpression="[a-zA-Z]+"></asp:RegularExpressionValidator>
        </td>
        <td>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="a" CssClass="auto-style12" ErrorMessage="RegNo is required"></asp:RequiredFieldValidator>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">Client Name</td>
        <td>
            <asp:TextBox ID="b" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7"></asp:TextBox>
        </td>
        <td>Email Address</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">Subcribe Contact</td>
        <td>
            <asp:TextBox ID="c" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7"></asp:TextBox>
        </td>
        <td>
            <asp:TextBox ID="cc" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8"></td>
        <td class="auto-style10">Item Bought</td>
        <td class="auto-style8">
            <asp:DropDownList ID="d" runat="server" Height="31px" style="margin-left: 0px" Width="313px" CssClass="auto-style7">
                <asp:ListItem>Modem</asp:ListItem>
                <asp:ListItem>Phone</asp:ListItem>
                <asp:ListItem Value="Subscribe Line">Subscribe SIM Line</asp:ListItem>
                <asp:ListItem>Internet</asp:ListItem>
            </asp:DropDownList>
        </td>
        <td class="auto-style8">
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="cc" ErrorMessage="Enter the right Email Address" style="color: #FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        </td>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
        <td class="auto-style8"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style11">Amount Paid</td>
        <td>
            <asp:TextBox ID="f" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7"></asp:TextBox>
            <br />
            <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="f" ErrorMessage="Only Numbers needed" style="color: #FF3300" ValidationExpression="[0-9]*"></asp:RegularExpressionValidator>
        </td>
        <td>Age<br />
            <asp:TextBox ID="bb" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7"></asp:TextBox>
            <br />
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="bb" ErrorMessage="Age must between 18 to 50" MaximumValue="50" MinimumValue="18" style="color: #FF3300"></asp:RangeValidator>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style13"></td>
        <td class="auto-style14">Date Of Registration</td>
        <td class="auto-style13">
            <asp:TextBox ID="ii" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7"></asp:TextBox>
        </td>
        <td class="auto-style13">ADD</td>
        <td class="auto-style13"></td>
        <td class="auto-style13"></td>
        <td class="auto-style13"></td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style9">
            <asp:GridView ID="GridView2" runat="server" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#FFF1D4" />
                <SortedAscendingHeaderStyle BackColor="#B95C30" />
                <SortedDescendingCellStyle BackColor="#F1E5CE" />
                <SortedDescendingHeaderStyle BackColor="#93451F" />
            </asp:GridView>
        </td>
        <td>
            <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="Griddata_SelectedIndexChanged" CellPadding="4" ForeColor="#333333" GridLines="None">
                <AlternatingRowStyle BackColor="White" />
                <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
                <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
                <SortedAscendingCellStyle BackColor="#FDF5AC" />
                <SortedAscendingHeaderStyle BackColor="#4D0000" />
                <SortedDescendingCellStyle BackColor="#FCF6C0" />
                <SortedDescendingHeaderStyle BackColor="#820000" />
            </asp:GridView>
        </td>
        <td>
            <asp:TextBox ID="p" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7" AutoPostBack="True" OnTextChanged="p_TextChanged"></asp:TextBox>
            <br />
            <asp:TextBox ID="q" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7" AutoPostBack="True" OnTextChanged="q_TextChanged"></asp:TextBox>
            <br />
            <asp:TextBox ID="r" runat="server" Height="25px" Width="308px" style="text-align: left" CssClass="auto-style7" AutoPostBack="True" OnTextChanged="r_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="z" runat="server" Text="Label"></asp:Label>
        </td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style9">&nbsp;</td>
        <td>
            <span><span class="glyphicon-phone topLineNavImageTextSeparator">
            <asp:Button ID="searchBtn" runat="server" Height="31px" OnClick="searchBtn_Click" Text="Search" Width="117px" />
            <asp:TextBox ID="txt2" runat="server" Height="25px" Width="257px"></asp:TextBox>
            </span></span></td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td class="auto-style9">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="search2" />
        </td>
        <td>
            &nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td>&nbsp;</td>
        <td colspan="5">
            <asp:Button ID="cmdsave" runat="server" Text="Submit" OnClick="cmdsave_Click" />
            <asp:Button ID="cmdclear" runat="server" Text="Clear" OnClick="cmdclear_Click" />
            <asp:Button ID="cmddel" runat="server" Text="Delete" OnClick="cmddel_Click" />
            <asp:Button ID="cmdupdate" runat="server" Text="Update" OnClick="cmdupdate_Click" />
            <asp:Button ID="cmdupdate0" runat="server" Text="View Data !" OnClick="cmdupdate0_Click" />
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td colspan="7">
            <asp:Label ID="ms" runat="server" style="color: #FF0000" Text="."></asp:Label>
        </td>
    </tr>
</table>
</asp:Content>
