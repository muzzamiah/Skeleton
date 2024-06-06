using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //variable to store the primary key value of the record to be deleted
    Int32 AddressId;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the customer to be deleted from the session object
        AddressId = Convert.ToInt32(Session["AddressId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the customer book collection class
        clsOrderCollection CustomerBook = new clsOrderCollection();
        //find the record to delete
        AddressBook.ThisOrder.Find(AddressId);
        //delete the record
        AddressBook.Delete();
        //redirect back to the main page
        Response.Redirect("Isaaq-4List.aspx");
    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        //redorect back to the main page
        Response.Redirect("Isaaq-4List.aspx");
    }
}