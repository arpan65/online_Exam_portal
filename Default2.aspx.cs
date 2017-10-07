using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
public partial class Default2 : System.Web.UI.Page
{
    SqlCommand cmd;
    SqlConnection con;
    SqlDataAdapter sda;
    DataSet ds = new DataSet();
    void show()
    {
        con.Open();
        string s = "select * from test";
        sda = new SqlDataAdapter(s, con);
        sda.Fill(ds, "t");
        GridView1.DataSource = ds.Tables["t"];
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ARPAN DAS\Desktop\k\App_Data\db1.mdf;Integrated Security=True;Connect Timeout=30");
        if (!Page.IsPostBack)
        {
            string nm = (Request.Cookies["def"].Value).ToString();
      
            show();
        }
    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        show();
    }

    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        con.Open();
        string r = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_ques")).Text;
        string a= ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_a")).Text;
        string b = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_b")).Text;
        string c = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_c")).Text;
        string d= ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_d")).Text;
        string c1 = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("txt_correct")).Text;
        string r1 = ((Label)GridView1.Rows[e.RowIndex].FindControl("Label1")).Text;


        string q = ("update test set ques='" + r + "',op_1= '" + a + "',op_2= '" + b + "',op_3= '" + c + "',op_4= '" + d + "',correct= '" + c1 + "' where  ques_no='" + r1 + "'");
        cmd = new SqlCommand(q, con);
        cmd.ExecuteNonQuery();
        GridView1.EditIndex = -1;
        con.Close();
        show();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        show();
    }

    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        if (((RadioButton)GridView1.Rows[e.RowIndex].FindControl("RadioButton1")).Checked == true)
        {
            string r = ((Label)GridView1.Rows[e.RowIndex].FindControl("Label1")).Text;
            string q = "delete from test where ques_no='" + r + "'";
            con.Open();
            cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            con.Close();
            show();
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        show();
    }

    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
 
                con.Open();
                string sl = ((TextBox)GridView1.FooterRow.FindControl("txt_sl")).Text;
                string qu = ((TextBox)GridView1.FooterRow.FindControl("txt_question")).Text;
                string o1 = ((TextBox)GridView1.FooterRow.FindControl("txt_op1")).Text;
                string o2 = ((TextBox)GridView1.FooterRow.FindControl("txt_opb")).Text;
                string o3 = ((TextBox)GridView1.FooterRow.FindControl("txt_opc")).Text;
                string o4 = ((TextBox)GridView1.FooterRow.FindControl("txt_opd")).Text;
                string co = ((TextBox)GridView1.FooterRow.FindControl("txt_cor")).Text;
                string q = "insert  into test ( ques_no,ques,op_1,op_2,op_3,op_4,correct )values('" + sl + "','" + qu + "','" + o1 + "','" + o2 + "','" + o3 + "','" + o4 + "','" + co + "')";
                cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                con.Close();
                show();

            
        }
    }

  


        
