using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Data.SqlClient;




public partial class registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //String Gender = "Male";

        //if (rbfemale.Checked)
        //{
        //    gender = rbfemale.Text;
        //}

        
    }
    protected void btnsubmit_Click(object sender, EventArgs e)
    {
        string Gender = "Male";
       
        if (rbfemale.Checked)
            Gender = rbfemale.Text;
        else
            Gender = rbmale.Text;
        SqlDataAdapter da = new SqlDataAdapter();

    clsregistration objreg=new clsregistration();
        objreg.Name=txtname.Text;
        objreg.Gender=Gender;
        objreg.EmailID=txtemailid.Text;
        objreg.Password=txtpassword.Text;
        objreg.ConfirmPassword=txtcnfpass.Text;
        objreg.Mobile=float.Parse(txtmob.Text);
        try
        {
            if (int.Parse(ddlday.SelectedItem.Value) >= 1 && int.Parse(ddlmon.SelectedItem.Value) >= 1 && int.Parse(ddlyear.SelectedItem.Value) >= 1)
            {

                objreg.DOB = ddlmon.SelectedItem.Value + "-" + ddlday.SelectedItem.Text + "-" + ddlyear.SelectedItem.Text;

                int result = objreg.Addregistration();
                if (result == 1)
                {
                    lblmessage.Text = "Inserted Successfully";
                    lblmessage.ForeColor = Color.Green;
                    // Response.Redirect("learngridview.aspx");
                    //passing the variable wuth value through the url
                    Response.Redirect("flag=" + result + "&name=" + txtname.Text + "&emailid=" + txtemailid.Text);
                }
                else if (result == 2)
                {
                    lblmessage.Text = "EmailID " + objreg.EmailID + "  Already Exits.Try again...";
                }
                else
                {
                    lblmessage.Text = "Please slect day Month and Year";
                }


            }
        }


        catch (Exception err)
        {
            lblmessage.Text = err.Message.ToString();
        }
        finally
        {
           // lblmessage.Text = "Registration Successful";
          //  Session["ViewState"]=true;
           // Response.Redirect("~/gridviewregistration.aspx");
        }

}

   
    protected void txtmob_TextChanged(object sender, EventArgs e)
    {
        txtmob.MaxLength = 10;
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        Session["ViewState"] = null;
        Response.Redirect("~/registration.aspx"); 
    }
    protected void ibtsubmit_Click(object sender, ImageClickEventArgs e)
    {
        string Gender = "Male";

        if (rbfemale.Checked)
            Gender = rbfemale.Text;
        else
            Gender = rbmale.Text;
        SqlDataAdapter da = new SqlDataAdapter();

        clsregistration objreg = new clsregistration();
        objreg.Name = txtname.Text;
        objreg.Gender = Gender;
        objreg.EmailID = txtemailid.Text;
        objreg.Password = txtpassword.Text;
        objreg.ConfirmPassword = txtcnfpass.Text;
        objreg.Mobile = float.Parse(txtmob.Text);
        try
        {
            if (int.Parse(ddlday.SelectedItem.Value) >= 1 && int.Parse(ddlmon.SelectedItem.Value) >= 1 && int.Parse(ddlyear.SelectedItem.Value) >= 1)
            {

                objreg.DOB = ddlmon.SelectedItem.Value + "-" + ddlday.SelectedItem.Text + "-" + ddlyear.SelectedItem.Text;

                int result = objreg.Addregistration();
                if (result == 1)
                {
                    lblmessage.Text = "Inserted Successfully";
                    lblmessage.ForeColor = Color.Green;
                    // Response.Redirect("learngridview.aspx");
                    //passing the variable wuth value through the url
                    Response.Redirect("flag=" + result + "&name=" + txtname.Text + "&emailid=" + txtemailid.Text);
                }
                else if (result == 2)
                {
                    lblmessage.Text = "EmailID " + objreg.EmailID + "  Already Exits.Try again...";
                }
                else
                {
                    lblmessage.Text = "Please slect day Month and Year";
                }


            }
        }


        catch (Exception err)
        {
            lblmessage.Text = err.Message.ToString();
        }
        finally
        {
            // lblmessage.Text = "Registration Successful";
            //  Session["ViewState"]=true;
            // Response.Redirect("~/gridviewregistration.aspx");
        }
    }
}
