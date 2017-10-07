using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Start : System.Web.UI.Page
{

    SqlConnection con;
   // SqlCommand cmd;
    static DataSet ds = new DataSet();
    SqlDataAdapter sda;
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ARPAN DAS\Desktop\k\App_Data\db1.mdf;Integrated Security=True;Connect Timeout=30");
        con.Open();
        show();

        if(!Page.IsPostBack)
        {
           
        
        }
    }
    void show()
    {
        //name_lbl.Text = "Welcome : " + (Request.Cookies["start"].Values["NAME"].ToString());     
        string s = "select * from test";
        sda = new SqlDataAdapter(s, con);
        sda.Fill(ds, "t");
        Label1.Text = ds.Tables["t"].Rows.Count.ToString();
        int ss = ds.Tables["t"].Rows.Count * 30;
        int mm = ss / 60;
        ss = ss-(mm * 60);
        Label2.Text=mm.ToString()+":"+ss.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie k9 = new HttpCookie("pro");
        k9.Values["name"] = name_lbl.Text;
        k9.Expires = DateTime.Now.AddSeconds(10);



        Response.Cookies.Add(k9);
        Response.Redirect("pro1.aspx");

    }
}