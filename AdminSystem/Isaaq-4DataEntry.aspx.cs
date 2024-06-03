using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    private object AnAddress;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btmConfirm_Click(object sender, EventArgs e)
    {
        //create a new instance of clsClass
        clsAddress clsAddress = new clsAddress();
        //capture the Order Details
        AnAddress.OrderNo = txtProductNoId.Text;
        Session["AnAddress"] = AnAddress;

        //Navigate to the view page
        Response.Redirect("AddressBookViewer.aspx");
    }

    protected void ButtonFind_Click(object sender, EventArgs e)
    {
        //create instance of the order class
        clsOrder AnAddress = new clsOrder();
        //create variable to store primary key 
        Int32 AddressId;
        //create a variable to store the result of the find operation 
        Boolean Found = false;
        //get the primary key entered by the user 
        AddressId = Convert.ToInt32(txtPriceId.Text);
        //find the record 
        Found = AnAddress.Find(AddressId);
        //if found      
        if (Found == true)
        {
            //display the value of the properties in the form
            txtPriceId.Text = AnAddress.Price;
            txtProductId.Text = AnAddress.ProductId;
            txtProductNoId.Text = AnAddress.ProductNoId.ToString();
            txtQuantityId.Text = AnAddress.QuantityId.ToString();

        }
    }
}