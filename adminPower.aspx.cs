using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class adminPower : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    SqlDataAdapter sda;
    DataSet ds = new DataSet();
    void show()
    {
        con.Open();
        string s = "select * from REQADMIN ";
        sda = new SqlDataAdapter(s, con);
        sda.Fill(ds, "t");
        GridView1.DataSource = ds.Tables["t"];
        GridView1.DataBind();
        con.Close();
    }
    void show1()
    {
        con.Open();
        string s = "select * from admin1 ";
        sda = new SqlDataAdapter(s, con);
        sda.Fill(ds, "t");
        GridView2.DataSource = ds.Tables["t"];
        GridView2.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ARPAN DAS\Desktop\k\App_Data\db1.mdf;Integrated Security=True;Connect Timeout=30");
        if (!Page.IsPostBack)
        {
            show();
            show1();
            if(GridView1.Rows.Count==0)
            {
                Response.Write("No Pending Request");
            }
        }


    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (((RadioButton)GridView1.Rows[e.RowIndex].FindControl("RadioButton1")).Checked == true)
        {
            string r = ((Label)GridView1.Rows[e.RowIndex].FindControl("lbl_id")).Text;
            string q = "delete from REQADMIN where ADMIN_ID='" + r + "'";
            con.Open();
            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }
    }




    protected void add_btn_Click(object sender, EventArgs e)
    {
        con.Open();
        for (int i = 0; i < GridView1.Rows.Count; i++)
        {
            if (((RadioButton)GridView1.Rows[i].FindControl("RadioButton1")).Checked == true)
            {
                string lname = ((Label)GridView1.Rows[i].FindControl("lbl_name")).Text;
                string id = ((Label)GridView1.Rows[i].FindControl("lbl_id")).Text;
                string otp = ((Label)GridView1.Rows[i].FindControl("lbl_otp")).Text;
                string mail = ((Label)GridView1.Rows[i].FindControl("lbl_mail")).Text;
                string mob = ((Label)GridView1.Rows[i].FindControl("lbl_mob")).Text;
                string q = ("insert  into admin1 ( NAME,ADMIN_ID,OTP_CREATED,E_MAIL,MOBILE )values('" + lname + "','" + id + "','" + otp + "','" + mail + "','" + mob + "')");
                string q1 = "delete from REQADMIN where ADMIN_ID='" + id + "'";
               
                cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand(q1, con);
                cmd.ExecuteNonQuery();
                con.Close();
                show();
               
            }
           
        }
    }

    protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (((RadioButton)GridView2.Rows[e.RowIndex].FindControl("RadioButton2")).Checked == true)
        {
            string r = ((Label)GridView2.Rows[e.RowIndex].FindControl("lab_id")).Text;
            string q = "delete from admin1 where ADMIN_ID='" + r + "'";
            con.Open();
            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            show1();
        }
    }
 
}
