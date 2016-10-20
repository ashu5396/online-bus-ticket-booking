using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class frmaddbooking : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
    protected void Button1_Click(object sender, EventArgs e)
    {
         clsbooking objbook = new clsbooking();
        objbook.TicketID =txttid.Text;     
        objbook.UserID =txtuid.Text;
        objbook.BusNo =txtbno.Text;
        objbook.JourneyDate = txtjourneydate.Text;
        objbook.No_Of_Passengers = int.Parse(txtnoofpassenger.Text);
        objbook.Amount =float.Parse(txtamount.Text);
        objbook.BookDate=txtbookdate.Text;
        objbook.SeatNo=txtseatno.Text;

      
        try
        { 
                            
               int result=objbook.InsertBooking();
                if(result==1)
                {
                    lblmessage.Text = "Inserted Successfully";
                    lblmessage.ForeColor = Color.Green;
                   
                }
                else if (result == 2)
                {
                    lblmessage.Text = "TicketID " + objbook.TicketID + "  Already Exits.Try again...";
                }
              
            }
        
        catch(Exception err)
        {
            lblmessage.Text=err.Message.ToString();
        }
    }





}

        
    
