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

public partial class Submit : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\ARPAN DAS\Desktop\k\App_Data\db1.mdf;Integrated Security=True;Connect Timeout=30");
    SqlCommand cmd = new SqlCommand();
    static DataSet ds = new DataSet();
    static int answer = 0;
    static int index = 0;
    static int wrong = 0;
    static int skip = 0;
    static int mm = 0, ss = 0;
    static int time_limit;
    static string skipmark = "";
    static int[] n;
    static int count = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {



            skipmark=( Request.Cookies["Submit1"].Values["skip"].ToString());
           n = new int[skipmark.Length];
            int len = skipmark.Length;
            count = 0;
            
            
            for (int i = 0; i < len;i++ )
            {
                if (skipmark[i] != '.')
                {
                    n[count] = (n[count] * 10) +( Convert.ToInt32(skipmark[i])-48);
                    
                }

                else
                {
                    count++;
                    n[count] = 0;
                }


            }
            

                mm = Convert.ToInt32(Request.Cookies["Submit1"].Values["mm"]);
            ss = Convert.ToInt32(Request.Cookies["Submit1"].Values["ss"]);
            answer = Convert.ToInt32(Request.Cookies["Submit1"].Values["right"]);
            wrong = Convert.ToInt32(Request.Cookies["Submit1"].Values["wrong"]);
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from test ", con);
            da.Fill(ds);
            time_limit = (30000 * ds.Tables[0].Rows.Count);
            

           Label1.Text = ds.Tables[0].Rows[n[index]-1]["ques"].ToString();

            RadioButton1.Text = ds.Tables[0].Rows[n[index]-1]["op_1"].ToString();
            RadioButton2.Text = ds.Tables[0].Rows[n[index]-1]["op_2"].ToString();
            RadioButton3.Text = ds.Tables[0].Rows[n[index]-1]["op_3"].ToString();
            RadioButton4.Text = ds.Tables[0].Rows[n[index]-1]["op_4"].ToString();
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

            string correct = ds.Tables[0].Rows[n[index]-1]["correct"].ToString();
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
            if (index -1< count)
            {

                Label1.Text = ds.Tables[0].Rows[n[index]-1]["ques"].ToString();
                RadioButton1.Text = ds.Tables[0].Rows[n[index]-1]["op_1"].ToString();
                RadioButton2.Text = ds.Tables[0].Rows[n[index]-1]["op_2"].ToString();
                RadioButton3.Text = ds.Tables[0].Rows[n[index]-1]["op_3"].ToString();
                RadioButton4.Text = ds.Tables[0].Rows[n[index]-1]["op_4"].ToString();

                if (count == index +1)
                {
                    btn_submit.Visible = true;
                    // btn_skip.Visible = false;


                }

            }
            else if (count== index)
            {
                HttpCookie k2 = new HttpCookie("Submit2");
                k2.Values["skip"] = skip.ToString();
                k2.Values["mm"] = mm.ToString();
               k2.Values["ss"] = ss.ToString();
                k2.Values["wrong"] = wrong.ToString();
                k2.Values["right"] = answer.ToString();
                k2.Expires = DateTime.Now.AddSeconds(10);



                Response.Cookies.Add(k2);
                Response.Redirect("Result.aspx");
            }
        }


    }



    protected void btn_skip_Click(object sender, EventArgs e)
    {

        index++;
        skip++;
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
        if (index  < count)
        {

            Label1.Text = ds.Tables[0].Rows[n[index]-1]["ques"].ToString();
            RadioButton1.Text = ds.Tables[0].Rows[n[index]-1]["op_1"].ToString();
            RadioButton2.Text = ds.Tables[0].Rows[n[index]-1]["op_2"].ToString();
            RadioButton3.Text = ds.Tables[0].Rows[n[index]-1]["op_3"].ToString();
            RadioButton4.Text = ds.Tables[0].Rows[n[index]-1]["op_4"].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            btn_skip.Enabled = true;

        }

        else if (index + 1 == count)
        {
            Label1.Text = ds.Tables[0].Rows[n[index]-1]["ques"].ToString();
            RadioButton1.Text = ds.Tables[0].Rows[n[index]-1]["op_1"].ToString();
            RadioButton2.Text = ds.Tables[0].Rows[n[index]-1]["op_2"].ToString();
            RadioButton3.Text = ds.Tables[0].Rows[n[index]-1]["op_3"].ToString();
            RadioButton4.Text = ds.Tables[0].Rows[n[index]-1]["op_4"].ToString();
            RadioButton1.Checked = false;
            RadioButton2.Checked = false;
            RadioButton3.Checked = false;
            RadioButton4.Checked = false;
            btn_skip.Enabled = true;
            btn_submit.Visible = true;

        }
        else
        {
            HttpCookie k2 = new HttpCookie("Submit2");
            k2.Values["skip"] = skip.ToString();
         k2.Values["mm"] = mm.ToString();
            k2.Values["ss"] = ss.ToString();
            k2.Values["wrong"] = wrong.ToString();
            k2.Values["right"] = answer.ToString();
            k2.Expires = DateTime.Now.AddSeconds(10);



            Response.Cookies.Add(k2);
            Response.Redirect("Result.aspx");

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
            skip++;
        if (ans != "")
        {

            string correct = ds.Tables[0].Rows[n[count - 1]]["correct"].ToString();
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

        // btn_next.Text = "Submit";
        HttpCookie k2 = new HttpCookie("Submit2");
        k2.Values["skip"] = skip.ToString();
         k2.Values["mm"] = mm.ToString();
         k2.Values["ss"] = ss.ToString();
        k2.Values["wrong"] = wrong.ToString();
        k2.Values["right"] = answer.ToString();
        k2.Expires = DateTime.Now.AddSeconds(10);



        Response.Cookies.Add(k2);
        Response.Redirect("Result.aspx");

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
            HttpCookie k2 = new HttpCookie("Submit2");
            k2.Values["skip"] = skip.ToString();
             k2.Values["mm"] = mm.ToString();
             k2.Values["ss"] = ss.ToString();
            k2.Values["wrong"] = wrong.ToString();
            k2.Values["right"] = answer.ToString();
            k2.Expires = DateTime.Now.AddSeconds(10);



            Response.Cookies.Add(k2);
            Response.Redirect("Result.aspx");
        }
    }
    protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
    {

    }
}



