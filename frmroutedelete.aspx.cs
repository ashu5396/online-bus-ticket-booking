using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class frmroutedelete : System.Web.UI.Page
{
    clsroute objroute = null;
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        //check the page is posted or not
        if (!this.IsPostBack)
        {
            objroute = new clsroute();
            DataSet ds = objroute.getAllRoute();
            ddlrouteno.DataSource = ds.Tables[0];
            //the table fieldname as hidden
            ddlrouteno.DataValueField = "RouteNo";

            ddlrouteno.DataBind();
        }
    }
    protected void btnbussubmit_Click(object sender, EventArgs e)
    {
        clsroute objroute = new clsroute();
        objroute.RouteNo = ddlrouteno.SelectedItem.Value;
        objroute.DeleteRoute();
    }
}