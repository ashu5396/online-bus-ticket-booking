using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    

    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        clsregistration objreg = new clsregistration();
        objreg.EmailID = txtemailid.Text;
        objreg.Password = txtpassword.Text;
        //SqlConnection con = new SqlConnection();
        //cn.Open();
        //clsDAL clsdal = new clsDAL();
        String q = "Select * from tblregistration where email_id ='" + txtemailid.Text + "'and Password='" + txtpassword.Text + "'";
        SqlCommand com = new SqlCommand(q);

        DataSet ds = clsDAL.getData(q);
        DataTable dt = ds.Tables[0];
        if (dt.Rows.Count == 1)
        {
            Session["myuser"] = dt;
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            Response.Write("Please Enter Valid email_id or Password");
        }
    }
    
}