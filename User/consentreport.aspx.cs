using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

public partial class User_consentreport : System.Web.UI.Page
{

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack == true)
        {
            get();
        }
    }

    void get()
    {
        con.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "Select *  from aadhar where status='Pending' and  cemail='" + Session["email"].ToString() + "' ";
        //cmd.Parameters.AddWithValue("@fname", TextBox1.Text);
        cmd.Connection = con;
        SqlDataAdapter sdr = new SqlDataAdapter(cmd);
        DataSet ds = new DataSet();
        sdr.Fill(ds);
        consent.DataSource = ds;
        consent.DataBind();
        con.Close();
    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        if (e.CommandName == "confirm")
        {
            // string id1 = (consent.SelectedRow.FindControl("ID") as Label).Text;
            int crow = Convert.ToInt32(e.CommandArgument.ToString());
            string id = consent.Rows[crow].Cells[0].Text;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update aadhar set status='Accepted' where id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Confirmed Successfully.')</script>");

                con.Close();
                get();

            }
        }
        if (e.CommandName == "reject")
        {
            // string id1 = (consent.SelectedRow.FindControl("ID") as Label).Text;
            int crow = Convert.ToInt32(e.CommandArgument.ToString());
            string id = consent.Rows[crow].Cells[0].Text;
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update aadhar set status='Rejected' where id=@id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Connection = con;
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('Rejected Successfully.')</script>");

                con.Close();
                get();

            }
        }
    }
}