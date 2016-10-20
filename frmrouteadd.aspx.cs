using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Drawing;
public partial class frmrouteadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

   
protected void  Button1_Click(object sender, EventArgs e)
{
    clsroute objroute = new clsroute();
        objroute.RouteNo =txtrouteno.Text;     
        objroute.RouteName = txtroutename.Text;
        objroute.Source = txtsource.Text;
        objroute.Destination = txtdestination.Text;
        objroute.TotalDistance = int.Parse(txtdistance.Text);
        objroute.Rate =int.Parse( txtrate.Text);
      
        try
        { 
                            
               int result=objroute.InsertRoute();
                if(result==1)
                {
                    lblmessage.Text = "Inserted Successfully";
                    lblmessage.ForeColor = Color.Green;
                   
                }
                else if (result == 2)
                {
                    lblmessage.Text = "RouteNo " + objroute.RouteNo + "  Already Exits.Try again...";
                }
              
            }
        
        catch(Exception err)
        {
            lblmessage.Text=err.Message.ToString();
        }
    }

protected void  Button2_Click(object sender, EventArgs e)
{
    Session["ViewState"] = null;

    Response.Redirect("frmrouteadd.aspx");
}
protected void Button3_Click(object sender, EventArgs e)
{

}
protected void txtroutename_TextChanged(object sender, EventArgs e)
{

}
}

    