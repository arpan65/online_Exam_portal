using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Result : System.Web.UI.Page
{
    static int skipped = 0;
    static int wrong = 0;
    static int right = 0;
    static int mm = 0;
    static int SS = 0;

    
   
    protected void Page_Load(object sender, EventArgs e)
    {
       skipped=Convert.ToInt32( Request.Cookies["Submit2"].Values["skip"]);
       wrong= Convert.ToInt32(Request.Cookies["Submit2"].Values["wrong"]) ;
       right = Convert.ToInt32(Request.Cookies["Submit2"].Values["right"]) ;
       mm = Convert.ToInt32(Request.Cookies["Submit2"].Values["mm"]) ;
       SS = Convert.ToInt32(Request.Cookies["Submit2"].Values["ss"]) ;
       tq_lbl.Text=( skipped + wrong + right).ToString();
       int fm = (skipped + wrong + right) * 3;
       int mo = (right * 3) - (wrong * 1);
       
       crct_lbl.Text = right.ToString();
       wrng_lbl.Text = wrong.ToString();
        mo_lbl.Text=(mo+"/"+fm).ToString();
        tt_lbl.Text = (mm + ":" + SS).ToString();
        skpd_lbl.Text = skipped.ToString();


    }
}