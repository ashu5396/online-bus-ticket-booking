using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class frmrouteedit : System.Web.UI.Page
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
    protected void Button2_Click(object sender, EventArgs e)
    {
       

        objroute = new clsroute();
        String routeno = ddlrouteno.SelectedItem.Value;
        DataSet ds = objroute.getRoutebyRouteNo(routeno);
        if (ds.Tables[0].Rows.Count >= 1)
        {
           foreach(DataRow dr in ds.Tables[0].Rows)
           {
            txtroutename.Text = dr["RouteName"].ToString();
            txtsource.Text = dr["Source"].ToString();
            txtdestination.Text = dr["Destination"].ToString();
            txtdistance.Text = dr["TotalDistance"].ToString();
            txtrate.Text = dr["Rate"].ToString();
           }
        }
        
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        clsroute objroute = new clsroute();
        objroute.RouteNo = ddlrouteno.Text;
        objroute.RouteName = txtroutename.Text;
        objroute.Source = txtsource.Text;
        objroute.Destination =txtdestination.Text;
        objroute.TotalDistance =int.Parse( txtdistance.Text);
        objroute.Rate = int.Parse(txtrate.Text);
      int result= objroute.EditRoute();
      if (result >= 1)
      {
          lblmessage.Text = "record Is updated Successfully";
          lblmessage.ForeColor = System.Drawing.Color.Green;
      }
    }
    }
