using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using System.Timers;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ARPAN DAS\Desktop\k\App_Data\db1.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd = new SqlCommand();
    static DataSet ds = new DataSet();
    static int index = 0;
    static int answer = 0;
    static int wrong = 0;
    static int skip = 0;
    static int mm = 0, ss = 0;
    static int time_limit;
    static string skipmark = "";

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            name_lbl.Text = "Welcome : " + (Request.Cookies["pro"].Values["name"].ToString());

            con.Open();
            index = 0;
            answer = 0;
            SqlDataAdapter da = new SqlDataAdapter("select * from test ", con);
            da.Fill(ds);
            time_limit = 30000 * ds.Tables[0].Rows.Count;


            Label1.Text = ds.Tables[0].Rows[0]["ques"].ToString();

            RadioButton1.Text = ds.Tables[0].Rows[0]["op_1"].ToString();
            RadioButton2.Text = ds.Tables[0].Rows[0]["op_2"].ToString();
            RadioButton3.Text = ds.Tables[0].Rows[0]["op_3"].ToString();
            RadioButton4.Text = ds.Tables[0].Rows[0]["op_4"].ToString();
            MultiView1.ActiveViewIndex = 0;

        }

    }
    protected void btn_next_Click(object sender, EventArgs e)
    {
        err_label.Text = "";

        string ans = "";

        if (RadioButton1.Checked == true)
        {
            ans = "op_1";
            //index++;
        }
        else if (RadioButton2.Checked == true)
        {
            ans = "op_2";
            // index++;
        }
        else if (RadioButton3.Checked == true)
        {
            ans = "op_3";
            //index++;
        }
        else if (RadioButton4.Checked == true)
        {
            ans = "op_4";
            // index++;
        }

        else
            err_label.Text = "Please mark an answer first or skip the question";
        if (ans != "")
        {

            string correct = ds.Tables[0].Rows[index]["correct"].ToString();
            if (ans == correct)
            {
                answer++;
            }
            else
            {
                wrong++;
            }
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            btn_skip.Enabled = true;



            index++;
            if (index < ds.Tables[0].Rows.Count)
            {

                Label1.Text = ds.Tables[0].Rows[index]["ques"].ToString();
                RadioButton1.Text = ds.Tables[0].Rows[index]["op_1"].ToString();
                RadioButton2.Text = ds.Tables[0].Rows[index]["op_2"].ToString();
                RadioButton3.Text = ds.Tables[0].Rows[index]["op_3"].ToString();
                RadioButton4.Text = ds.Tables[0].Rows[index]["op_4"].ToString();

                if (ds.Tables[0].Rows.Count == index + 1)
                {
                    btn_submit.Visible = true;
                    // btn_skip.Visible = false;


                }

            }
            else if (ds.Tables[0].Rows.Count == index)
            {
                HttpCookie k1 = new HttpCookie("Submit1");
                k1.Values["skip"] = skipmark;
                k1.Values["mm"] = mm.ToString();
                k1.Values["ss"] = ss.ToString();
                k1.Values["wrong"] = wrong.ToString();
                k1.Values["right"] = answer.ToString();
                k1.Expires = DateTime.Now.AddSeconds(10);



                Response.Cookies.Add(k1);
                Response.Redirect("Submit.aspx");

            }
        }


    }



    protected void btn_skip_Click(object sender, EventArgs e)
    {

        index++;
        skipmark = skipmark + (index).ToString() + ".";
        err_label.Text = skipmark;
        RadioButton1.Enabled = true;
        RadioButton2.Enabled = true;
        RadioButton3.Enabled = true;
        RadioButton4.Enabled = true;
        // UpdatePanel1.Visible = false;
        // string ans = " ";
        /*if (btn_next.Text == "next")
        {
            if (RadioButton1.Checked == true)
            {
                ans = "op_1";
            }
            else if (RadioButton2.Checked == true)
            {
                ans = "op_2";
            }
            else if (RadioButton3.Checked == true)
            {
                ans = "op_3";
            }
            else if (RadioButton4.Checked == true)
            {
                ans = "op_4";
            }
            string correct = ds.Tables[0].Rows[index]["correct"].ToString();
            if (ans == correct)
            {
                answer++;
            }
            else
            {
                skip++;
            }
          */
        if (index + 1 < ds.Tables[0].Rows.Count)
        {

            Label1.Text = ds.Tables[0].Rows[index]["ques"].ToString();
            RadioButton1.Text = ds.Tables[0].Rows[index]["op_1"].ToString();
            RadioButton2.Text = ds.Tables[0].Rows[index]["op_2"].ToString();
            RadioButton3.Text = ds.Tables[0].Rows[index]["op_3"].ToString();
            RadioButton4.Text = ds.Tables[0].Rows[index]["op_4"].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            btn_skip.Enabled = true;

        }

        else if (index + 1 == ds.Tables[0].Rows.Count)
        {
            Label1.Text = ds.Tables[0].Rows[index]["ques"].ToString();
            RadioButton1.Text = ds.Tables[0].Rows[index]["op_1"].ToString();
            RadioButton2.Text = ds.Tables[0].Rows[index]["op_2"].ToString();
            RadioButton3.Text = ds.Tables[0].Rows[index]["op_3"].ToString();
            RadioButton4.Text = ds.Tables[0].Rows[index]["op_4"].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            btn_skip.Enabled = true;
            btn_submit.Visible = true;

        }
        else
        {
            HttpCookie k1 = new HttpCookie("Submit1");
            k1.Values["skip"] = skipmark;
            k1.Values["mm"] = mm.ToString();
            k1.Values["ss"] = ss.ToString();
            k1.Values["wrong"] = wrong.ToString();
            k1.Values["right"] = answer.ToString();
            k1.Expires = DateTime.Now.AddSeconds(10);



            Response.Cookies.Add(k1);
            Response.Redirect("Submit.aspx");

        }





    }
    protected void btn_submit_Click(object sender, EventArgs e)
    {

        err_label.Text = "";

        string ans = "";

        if (RadioButton1.Checked == true)
        {
            ans = "op_1";
            //index++;
        }
        else if (RadioButton2.Checked == true)
        {
            ans = "op_2";
            // index++;
        }
        else if (RadioButton3.Checked == true)
        {
            ans = "op_3";
            //index++;
        }
        else if (RadioButton4.Checked == true)
        {
            ans = "op_4";
            // index++;
        }

        else
            skipmark = skipmark + (ds.Tables[0].Rows.Count).ToString() + ".";
        if (ans != "")
        {

            string correct = ds.Tables[0].Rows[ds.Tables[0].Rows.Count - 1]["correct"].ToString();
            if (ans == correct)
            {
                answer++;
            }
            else
            {
                wrong++;
            }
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
        }


        HttpCookie k1 = new HttpCookie("Submit1");
        k1.Values["skip"] = skipmark;
        k1.Values["mm"] = mm.ToString();
        k1.Values["ss"] = ss.ToString();
        k1.Values["wrong"] = wrong.ToString();
        k1.Values["right"] = answer.ToString();
        k1.Expires = DateTime.Now.AddSeconds(10);



        Response.Cookies.Add(k1);
        Response.Redirect("Submit.aspx");



        // UpdatePanel1.Visible = true;
        //btn_skip.Visible = false;


    }




    protected void Timer1_Tick(object sender, EventArgs e)
    {
        timer_label.Text = mm.ToString() + ":" + ss.ToString();
        ss++;
        if (ss == 60)
        {
            mm++;
            ss = 0;

        }
        if ((mm * 60) + ss >= time_limit)
        {

            HttpCookie k1 = new HttpCookie("Submit1");
            k1.Values["skip"] = skipmark;
            k1.Values["mm"] = mm.ToString();
            k1.Values["ss"] = ss.ToString();
            k1.Values["wrong"] = wrong.ToString();
            k1.Values["right"] = answer.ToString();
            k1.Expires = DateTime.Now.AddSeconds(10);



            Response.Cookies.Add(k1);
            Response.Redirect("Submit.aspx");
        }
    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }
}



