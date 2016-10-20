using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class frmadminchangepass : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnchnpass_Click(object sender, EventArgs e)
    {
       // clsDAL objdal = new clsDAL();
        int update = 0;
        String q = "update tbladmin set Password='" + txtadminnewpassword.Text + "' where User_Name='" + txtadminemailid.Text + "'";
        String q1 = "Select * from tbladmin where Password='" + txtadminoldpassword.Text + "' and User_Name='" + txtadminemailid.Text + "'";
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
                lblmessage.Text = "Please Check Your User_Name";
            }
        }
        else
        {
            lblmessage.Text = "Old Password is incorrect";
        }
    }
}