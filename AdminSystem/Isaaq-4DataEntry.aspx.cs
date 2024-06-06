
using System;
using System.Activities.Expressions;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

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
        AnAddress.ProductNo = txtProductNoId.Text;
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
        //capture the date added 
        string DateAdded = txtDateAdded.Text;
        string Quantity = txtQuantityId.Text;
        string ProductName = txtProductId.Text;
        string OrderNo = txtProductNoId.Text;
        string OrderDate = txtOrderDate.Text;
        string DateAdded = txtDateAdded.Text;
        string Price = txtPriceId.Text;
        string OrderAddress = OrderAddress.Text;
        string Yes = chkYes.Text;
        string no = chkNo.Text;
        string Error = "";

        Error = AnAddress.Valid((ProductName, Quantity, OrderNo, Price, OrderDate, OrderAddress, DateAdded,);
        if (Error == "")
        {
            AnAddress.AddressId = AddressId;
            AnAddress.ProductName = ProductName;
            AnAddress.Quantity = Quantity;
            AnAddress.OrderNo = OrderNo;
            AnAddress.Price = Convert.ToInt32(Price);
            AnAddress.DateAdded = Convert.ToDateTime(DateAdded);
            AnAddress.OrderDate = OrderDate;
            AnAddress.OrderAddress = OrderAddress;
            AnAddress.Yes = chkYes.Checked;
            AnAddress.No = chkNo.Checked;
            clsAddressCollection OrderList = new clsAddressCollection();

            if (AddressId == -1)
            {
                OrderList = ThisOrder = AnAddress;
                OrderList.Add();
            }
            else
            {
                OrderList.ThisAddress.Find(AddressId);
                AddressId.ThisOrder = AnAddress;
                OrderList.Update();
                Response.Redirect("Isaaq-4DataEntry.aspx");
                else
                {
                    lblError.Text = Error;

                }
                void DisplayAddress()
                    clsOrderCollection AddressBook = new clsOrderCollection();
                AddressBook.ThisOrder.Find(AddressId);
                txtPriceId.Text = AddressId.ThisOrder.Price.ToString();
                txtProductId.Text = AddressId.ThisOrder.ProductId.ToString();
                txtProductNoId.Text = AddressId.ThisOrder.ProductNo.ToString();
                txtQuantityId.Text AddressId.ThisOrder.Quantity.ToString();
                chkNo.Text = AddressId.ThisOrder.no.Active();
                chkYes.Text = AddressId.ThisOrder.yes.Active();



            }

        }
    }

