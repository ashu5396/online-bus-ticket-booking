﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class frmforgetpassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    
    protected void btnchnpass_Click(object sender, EventArgs e)
    {                                                                                                                                                       
        //clsDAL objdal = new clsDAL();
        
     String q="Select * from tblregistration where Email_Id='"+txtemailid.Text+"'";

     DataSet ds= clsDAL.getData(q);
     if (ds.Tables[0].Rows.Count>=1)
     {
         String pass =ds.Tables[0].Rows[0]["password"].ToString();
         lblmessage.Text = pass;
     }
     else
     {





















































































































































































































































































































































        lblmessage.Text = "Invalid Email_ID";
     }
     
    }
}