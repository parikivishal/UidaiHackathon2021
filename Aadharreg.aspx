<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Aadharreg.aspx.cs" Inherits="Aadharreg" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .style1
        {
        }
        .style2
        {
            width: 53px;
            height: 27px;
        }
        .style4
        {
            height: 27px;
            text-align: left;
        }
        .style5
        {
            text-align: left;
            height: 20px;
        }
        .style8
        {
            text-align: center;
        }
        .style11
        {
            font-size: xx-large;
        }
        .style12
        {
            color: #0033CC;
            height: 27px;
            text-align: right;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
    <center>
    <table>
<div style="background-color:Red;">
<h2 style="color:White;font-weight:bold;text-align:center" class="style11">AADHAAR ENROLMENT</h2>
</div>

    <br />
    
    <table class="nav-" class="style1" style="border-style: solid; border-color: inherit; border-width: medium; width: 50%; height: 364px; margin-left: 322px; right: auto; left: auto; bottom: auto; box-shadow: 10px 10px 5px #888888; margin-top: 0px;" >
        <tr>
            <td colspan="4">
                &nbsp;</td>
            <td colspan="4">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="text-left" colspan="4">
                Full Name:</td>
    </center>


            <td colspan="4" class="txt-lt">
                <asp:TextBox ID="TextBox7" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
        </tr>
    <center>
        <tr>
            <td class="style5" colspan="4">
                Date of Birth:</td>
            <td class="style5" colspan="4">
                <asp:TextBox ID="TextBox8" runat="server" autocomplete="off" TextMode="Date" />

            </td>
        </tr>
        <tr>
            <td class="text-left" colspan="4">
                Gender</td>
            <td class="txt-lt" colspan="4">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" 
                    RepeatDirection="Horizontal">
                    <asp:ListItem>Male</asp:ListItem>
                    <asp:ListItem>Female</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
    <center>
        <tr>
            <td class="style12" colspan="4">
            </td>
            <td class="style4" colspan="4">
            </td>
        </tr>
    </center>


    </center>


        <tr>
            <td class="txt-rt" colspan="4">
                Address: C/o
            </td>
    <center>
    <center>
            <td class="txt-lt" colspan="4">
                <asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine" 
                    AutoCompleteType="Disabled"></asp:TextBox>
            </td>
        </tr>
    <center>
        <tr>
            <td class="text-left">
                House No./ Bldg./ Apt:</td>
            <td class="text-left" colspan="3">
                <asp:TextBox ID="TextBox4" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
            <td class="text-left">
                Street/ Road/ Lane:</td>
            <td class="text-left" colspan="3">
                <asp:TextBox ID="TextBox6" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-left">
                Landmark:</td>
            <td class="text-left" colspan="3">
                <asp:TextBox ID="TextBox3" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
            <td class="text-left">
                Area/ Locality/ Sector:</td>
            <td class="text-left" colspan="3">
                <asp:TextBox ID="TextBox9" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style5">
                Village/ Town/ City:</td>
            <td class="style5" colspan="3">
                <asp:TextBox ID="TextBox2" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
            <td class="style5">
                Post Office:</td>
            <td class="style5" colspan="3">
                <asp:TextBox ID="TextBox10" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-left">
                District:</td>
            <td class="text-left" colspan="2">
                <asp:TextBox ID="TextBox1" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
            <td class="text-left">
                Sub-District:</td>
            <td class="text-left">
                <asp:TextBox ID="TextBox11" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
            <td class="text-left" colspan="2">
                State:</td>
            <td class="text-left">
                <asp:TextBox ID="TextBox12" runat="server" AutoCompleteType="Disabled"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="text-left" colspan="2">
                E-Mail:</td>
            <td class="text-left">
                <asp:TextBox ID="TextBox13" runat="server" TextMode="Email"></asp:TextBox>
            </td>
            <td class="text-left">
                Mobile No.: |</td>
            <td class="text-left" colspan="2">
                <asp:TextBox ID="TextBox14" runat="server" MaxLength="10"></asp:TextBox>
            </td>
            <td class="text-left">
                PIN Code: </td>
            <td class="text-left">
                <asp:TextBox ID="TextBox15" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="style1">
                &nbsp;</td>
            <td class="text-left" colspan="2">
                &nbsp;</td>
            <td class="text-left" colspan="5">
                &nbsp;</td>
        </tr>
    

        <tr>
            <td class="style8" colspan="8">
                <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Submit" />
            </td>
        </tr>
  
        <tr>
            <td class="style1" colspan="8">
                <asp:Label ID="Label1" runat="server" 
                    style="font-weight: 700; font-size: x-large; color: #FF0000;"></asp:Label>
            </td>
        </tr>
    
    
    </table>
    </center>


    </center>


    </center>


        </tr>
    </table>


</asp:Content>

