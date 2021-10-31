using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

public partial class User_consentapply : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);


    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
        string status = "Pending";
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "update aadhar set cemail='"+TextBox1.Text+"',status=@status where email='"+Session["email"].ToString()+"'";
        //cmd.Parameters.AddWithValue("@fullname", Session["fullname"].ToString());
        //cmd.Parameters.AddWithValue("@aadhar", Session["aadharno"].ToString());
        //cmd.Parameters.AddWithValue("@email", Session["email"].ToString());
        Session["cemail"] = TextBox1.Text;
        cmd.Parameters.AddWithValue("@cemail", TextBox1.Text);
        //cmd.Parameters.AddWithValue("@address", Session["address"].ToString());
        cmd.Parameters.AddWithValue("@status", status);

        cmd.Connection = con;
        try
        {


            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {

                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Consent Requested successfully')</script>");


            }
            else
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Error Requesting Consent')</script>");
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex.Message);
        }
        finally
        {
            con.Close();
            con.Dispose();
            getmail();
        }

    }
     void getmail()
    {

            
                MailMessage Msg = new MailMessage();
                Msg.From = new MailAddress(TextBox1.Text);
                Msg.To.Add(TextBox1.Text);
                Msg.Subject = "Request for Address from Your Neighbour";
                Msg.Body = "Hi, <br/>I am new to this location  my  name is " + Session["fullname"].ToString()+"<br>I want your details for my Aadhaar Update <br>Plse Confirm my request in your portal <br> If any Queries my Mail id is "+Session["email"].ToString();
                Msg.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential("parikivishal01052001@gmail.com", "Vishal12@");
                smtp.EnableSsl = true;
                smtp.Send(Msg);
            }
            
    
}