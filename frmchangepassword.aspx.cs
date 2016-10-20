using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class frmchangepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnchnpass_Click(object sender, EventArgs e)
    {
       // clsDAL objdal = new clsDAL();
        int update = 0;
        String q = "update tblregistration set Password='" + txtnewpassword.Text + "' where Email_ID='" + txtemailid.Text + "'";
        String q1 = "Select * from tblregistration where Password='" + txtoldpassword.Text +"' and Email_ID='" + txtemailid.Text + "'";
        bool flag = clsDAL.DuplicateCheck(q1);
        if (flag)
        {
            update = clsDAL.InsertUpdateDelete(q);
            if (update == 1)
            {
                lblmessage.Text = "Password Change Successfull";
                lblmessage.ForeColor = Color.Green;
            }
            else
            {
                lblmessage.Text = "Please Check Your Email_ID";
            }
        }
        else
        {
            lblmessage.Text = "Old Password is incorrect";
        }
       
    }
}