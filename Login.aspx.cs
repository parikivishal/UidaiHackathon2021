using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from aadhar where aadharno='" + TextBox1.Text + "' and mobile='" + TextBox2.Text + "'";
            cmd.Connection = con;
            SqlDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Session["fullname"] = sdr[1].ToString();
                Session["address"] = sdr[4].ToString();
                Session["aadharno"] = TextBox1.Text;
                Session["email"] = sdr[14].ToString();
                

                Response.Redirect("User/Default.aspx");
                //Response.Write("hello");
            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Invalid Username or Password')</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
    }
}