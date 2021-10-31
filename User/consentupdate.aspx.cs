using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class User_consentupdate : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            SqlDataReader rdr;
            cmd.CommandText = "select address from aadhar where cemail=(select cemail from aadhar where status='Accepted' and email='" + Session["email"].ToString() + "')";
            cmd.Connection = con;
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                TextBox1.Text = rdr.GetString(0);
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        finally
        {
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            con.Open();            
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update aadhar set address='" + TextBox1.Text + "' where email='" + Session["email"].ToString() + "'";
            cmd1.Connection = con;
            int i = cmd1.ExecuteNonQuery();
            if (i > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Updated successfully')</script>");
                TextBox1.Text = "";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
        finally
        {
            con.Close();
            con.Dispose();
        }
    }
}