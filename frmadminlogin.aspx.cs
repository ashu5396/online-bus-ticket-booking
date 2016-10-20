using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class frmadminlogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void ImageButton1_Click1(object sender, ImageClickEventArgs e)
    {
        clsregistration objreg = new clsregistration();
        objreg.EmailID = txtadminemailid.Text;
        objreg.Password = txtadminpassword.Text;
        //SqlConnection con = new SqlConnection();
        //cn.Open();
        clsDAL clsdal = new clsDAL();
        String q = "Select * from tbladmin where User_Name ='" + txtadminemailid.Text + "'and Password='" + txtadminpassword.Text + "'";
        SqlCommand com = new SqlCommand(q);

        DataSet ds = clsDAL.getData(q);
        DataTable dt = ds.Tables[0];
        if (dt.Rows.Count == 1)
        {
            Response.Redirect("~/Default.aspx");
        }
        else
        {
            lblmessage.Text=("Please Enter Valid User_Name or Password");
        }
    }
}
