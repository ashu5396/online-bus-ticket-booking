using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class frmrouteadd : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnbusreset_Click(object sender, EventArgs e)
    {
        Session["ViewState"] = null;
        Response.Redirect("~/frmbusadd.aspx");


    }
    protected void btnbussubmit_Click(object sender, EventArgs e)
    {

    }
}