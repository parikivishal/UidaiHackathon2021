<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            font-weight: bold;
            text-align: center;
        }
    </style>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style1" style="border-style: solid; border-color: inherit; border-width: medium; width: 43%; height: 364px; margin-left: 322px; right: auto; left: auto; bottom: auto; box-shadow: 10px 10px 5px #888888; margin-top: 0px;">
        <tr>
            <td class="style2" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:Label ID="Label1" runat="server" 
                    style="font-size: xx-large; color: #FF5050; text-align: center" 
                    Text="Aadhaar Login"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:TextBox ID="TextBox1" Height="32px" Width="192px"  placeholder="Aadhaar Number" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="TextBox1" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:TextBox ID="TextBox2" runat="server" Height="32px" Width="192px" placeholder="Password" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="TextBox2" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2" colspan="2">
                <asp:Button ID="Button1" runat="server" Text="Sign in" onclick="Button1_Click" Width="195px" Height="35px" />
                </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

