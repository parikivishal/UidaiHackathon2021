using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

public partial class Aadharreg : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Random rnd = new Random();
        double aadhar = Convert.ToDouble(DateTime.Now.ToString("ddMMyyyyHH00")) + rnd.Next(10, 99);
        string agreement = "NO";
        int otp = rnd.Next(1234,4321);
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
          SqlCommand cmd = new SqlCommand();
          cmd.CommandType = CommandType.Text;
          cmd.CommandText = "insert into aadhar(fullname,dob,gender,address,house,street,landmark,area,village,postoffice,district,subdistrict,state,email,mobile,pincode,aadharno,agreement,otp) values('" + TextBox7.Text + "','" + TextBox8.Text + "','" + RadioButtonList1.SelectedItem.Text + "','" + TextBox5.Text + "','" + TextBox4.Text + "','" + TextBox6.Text + "','" + TextBox3.Text + "','" + TextBox9.Text + "','" + TextBox2.Text + "','" + TextBox10.Text + "','" + TextBox1.Text + "','" + TextBox11.Text + "','" + TextBox12.Text + "','" + TextBox13.Text + "','" + TextBox14.Text + "','" + TextBox15.Text + "','"+aadhar+"','"+agreement+"','"+otp+"')";
          cmd.Connection = con;
          con.Open();
          int i = cmd.ExecuteNonQuery();
          try
          {
              if (i > 0)
              {
                  ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Aadhar Registration Successfull')</script>");
                  Label1.Text = "Your Aadhar No is:"+aadhar;
                  TextBox1.Text = "";
                  TextBox2.Text = "";
                  TextBox3.Text = "";
                  TextBox4.Text = "";
                  TextBox5.Text = "";
                  TextBox6.Text = "";
                  TextBox7.Text = "";
                  TextBox8.Text = "";
                  TextBox9.Text = "";
                  TextBox10.Text = "";
                  TextBox11.Text = "";
                  TextBox12.Text = "";
                  TextBox13.Text = "";
                  TextBox14.Text = "";
                  TextBox15.Text = "";
                  RadioButtonList1.ClearSelection();
              }
              else
              {
                  ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Error')</script>");
              }
          }
          catch (Exception ex)
          {
              Response.Write(ex.Message);
          }

     
    }
}