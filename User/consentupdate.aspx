
<%@ Page Title="" Language="C#" MasterPageFile="~/User/MasterPage.master" AutoEventWireup="true" CodeFile="consentupdate.aspx.cs" Inherits="User_consentupdate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .style5
    {
        width: 100%;
    }
    .style6
    {
        height: 23px;
    }
        .style7
        {
            height: 23px;
            text-align: center;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table class="style5">
    <tr>
        <td class="style7">
        </td>
        <td class="style6">
        </td>
    </tr>
    <tr>
        <td class="style7" colspan="2">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="style7" colspan="2">
            <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Update" />
        </td>
    </tr>
</table>
</asp:Content>

