using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Collections;
using System.Text;
//using System.Web.Mail;
using System.Net.Mail;
using System.Net;


public partial class _Default : System.Web.UI.Page
{
    SqlConnection con;
    SqlCommand cmd;
    static DataSet ds = new DataSet();
    protected void Page_Load(object sender, EventArgs e)
    {
        con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ARPAN DAS\Desktop\project\App_Data\userdataa.mdf;Integrated Security=True");
        con.Open();
        if (!Page.IsPostBack)
        {

        }
    }

    protected void signup_img_btn_Click(object sender, ImageClickEventArgs e)
    {
        Panel1.Visible = true;
        Panel2.Visible = false;
    }
    protected void signin_img_btn_Click(object sender, ImageClickEventArgs e)
    {
        Panel2.Visible = true;
        Panel1.Visible = false;
    }



    protected void signin_btn_Click(object sender, EventArgs e)
    {

        int k = 0;
        int looping = 0;
        SqlDataAdapter da = new SqlDataAdapter("select UID,E_MAIL from user_data1", con);
        da.Fill(ds, "t");
        for (looping = 0; looping < ds.Tables["t"].Rows.Count; looping++)
        {

            if (ds.Tables["t"].Rows[looping]["UID"].ToString().Equals(uid_tb2.Text.ToString()))
            {
                k = looping;
                break;
            }


        }
        if (k != looping)


            err_lbl2.Text = "Your UID is not registered with us , Please Sign Up first ";
        else
        {
            StringBuilder s1 = new StringBuilder(pwd_tb2.Text.ToString());
            int len = s1.Length;
            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = (char)(s1[i] + i + s1.Length);

            }
            SqlDataAdapter da1 = new SqlDataAdapter("select PASSWORD,NAME from user_data1", con);
            da1.Fill(ds, "t1");
            Response.Write(looping);


           if (ds.Tables["t1"].Rows[looping]["PASSWORD"].ToString().Equals(s1.ToString()))
            {
                HttpCookie k3 = new HttpCookie("start");
                k3.Values["name"] = ds.Tables["t1"].Rows[looping]["NAME"].ToString();

                k3.Expires = DateTime.Now.AddSeconds(10);
                Response.Cookies.Add(k3);
                Response.Redirect("Start.aspx");

            }
            else
                err_lbl2.Text = "Wrong Password . Please re-enter ";
        }

    }
    protected void signup_btn_Click(object sender, EventArgs e)
    {
        err_lbl1.Text = "";
        string uid = (uid_tb.Text);
        string n = name_tb.Text;
        string p = pwd_tb.Text;
        string cp = cnfpwd_tb.Text;
        string em = email_tb.Text;
        string mb = mb_tb.Text;
        int k = 0;
        int looping = 0;
        SqlDataAdapter da = new SqlDataAdapter("select UID,E_MAIL from user_data1", con);
        da.Fill(ds, "t");
        for (looping = 0; looping < ds.Tables["t"].Rows.Count; looping++)
        {

            if (ds.Tables["t"].Rows[looping]["UID"].ToString().Equals(uid_tb.Text.ToString()))
                k = 1;
        }
        if (k == 0)
        {
            if (cp.Equals(p))
            {

                StringBuilder s1 = new StringBuilder(p);
                int len = s1.Length;
                for (int i = 0; i < s1.Length; i++)
                {
                    s1[i] = (char)(s1[i] + i + s1.Length);

                }


                string q = "insert into user_data1 values('" + uid + "','" + n + "','" + s1 + "','" + em + "','" + mb + "')";
                cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();
                err_lbl1.Text = "Sign Up successfull! Please sign in to your new account .";
            }
            else

                err_lbl1.Text = "Your passwords don't match , please re-enter";
        }
        else

            err_lbl1.Text = "You already own an account . Please sign in ";



    }
    protected void frgtpwd_btn_Click(object sender, EventArgs e)
    {
        // if (uid_label2.Text.Equals(""))
        //   err_lbl2.Text = "Please enter your UID";
        //con.Open();
        string q = "select UID,E_MAIL,PASSWORD from user_data1";
        SqlDataAdapter da1 = new SqlDataAdapter(q, con);
        da1.Fill(ds, "t2");



        int k = 0, looping = 0;
        for (looping = 0; looping < ds.Tables["t2"].Rows.Count; looping++)
        {

            if (ds.Tables["t2"].Rows[looping]["UID"].ToString().Equals(uid_tb2.Text.ToString()))
            {
                k = 1;
                break;
            }
        }
        if (k == 0)
        {
            err_lbl2.Text = " Your UID is not registered with us , Please Sign Up first ";
        }
        else
        {
            string recipent = ds.Tables["t2"].Rows[looping]["E_MAIL"].ToString();
            // MailMessage mm = new MailMessage("princearyan.57@gmail.com", recipent);
            //mm.Subject = "Online Exam Portal Password Recovery";
            StringBuilder s1 = new StringBuilder(ds.Tables["t2"].Rows[looping]["PASSWORD"].ToString());
            int len = s1.Length;
            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = (char)(s1[i] - i - s1.Length);

            }
            /* mm.Body = "Your Password is : " + s1;
             mm.IsBodyHtml = false;
             SmtpClient smtp = new SmtpClient();
             smtp.Host = "smtp.gmail.com";
             smtp.EnableSsl = true;
             NetworkCredential nw = new NetworkCredential("princearyan.57@gmail.com", "iam@7278259703");
             smtp.UseDefaultCredentials = true;
             smtp.Credentials = nw;
             smtp.Port = 587;
             smtp.Send(mm);
             ClientScript.RegisterStartupScript(GetType(), "alert", "alert('Email sent.');", true);
             */


        }

    }
    protected void admin_btn_Click(object sender, EventArgs e)
    {
        HttpCookie k1 = new HttpCookie("admin");

        k1.Expires = DateTime.Now.AddSeconds(10);
        Response.Cookies.Add(k1);
        Response.Redirect("admin_login.aspx");
    }
    protected void admin_btn2_Click(object sender, EventArgs e)
    {
        HttpCookie k1 = new HttpCookie("admin");

        k1.Expires = DateTime.Now.AddSeconds(10);
        Response.Cookies.Add(k1);
        Response.Redirect("admin_login.aspx");
    }
    
}