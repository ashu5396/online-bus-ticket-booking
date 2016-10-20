using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            caljourney.Visible = false;


        }
    }
    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
        if (caljourney.Visible)
        {
            caljourney.Visible = false;
        }
        else
        {
            caljourney.Visible = true;
        }
    }



    protected void caljourney_SelectionChanged(object sender, EventArgs e)
    {
        txtjourney.Text = caljourney.SelectedDate.ToString("d");
        caljourney.Visible = false;
    }


    protected void btnsearch_Click(object sender, EventArgs e)
    {

    }
}