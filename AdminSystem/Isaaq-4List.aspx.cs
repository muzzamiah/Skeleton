using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayOrder();
        }

    }

    void DisplayOrder()
    {
        //create an instance of the Customer Collection
        clsOrderCollection Orders = new clsOrderCollection();
        //set the data source to list of customers in the collection
        lstOrderList.DataSource = Orders.List;
        //set the name of the primary key
        lstOrderList.DataValueField = "Product Name";
        //set the data field to display
        lstOrderList.DataTextField = "Order Date";
        //bind the data to the list
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record 
        Session["AddressId"] = -1;
        //redirect to the data entry page
        Response.Redirect("Isaaq-4DataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 AddressId;
        if (lstOrderList.SelectedIndex != -1)
        {
            AddressId = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["AddressId"] = AddressId;
            Response.Redirect("Isaaq-4DataEntry.aspx");
        }
        else
            lblError.Text = "Please select a record from the list to edit"
   }
                }

}