using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class frmdeletebooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //check the page is posted or not
        if (!this.IsPostBack)
        {
          clsbooking  objbook = new clsbooking();
          DataSet ds = objbook.getAllTicketID();
          DropDownList1.DataSource = ds.Tables[0];
            //the table fieldname as hidden
          DropDownList1.DataValueField = "TicketID";

          DropDownList1.DataBind();
        }
    }
    protected void btndelete_Click(object sender, EventArgs e)
    {
        clsbooking objbook = new clsbooking();
        objbook.TicketID = DropDownList1.SelectedItem.Value;
        objbook.DeleteBooking();
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    protected void btnsearch_Click(object sender, EventArgs e)
    {

    }
}