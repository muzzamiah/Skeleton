using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

public partial class CustomerStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer clscustomer = new clsCustomer();

        //retreieve data from the database
        DataTable dT = clscustomer.StatisticsGroupedByCustomerLastName();

        //upload dT into Gridview
        GridViewStGroupByCustomerLastName.DataSource = dT;
        GridViewStGroupByCustomerLastName.DataBind();

        //chsnge the header of the first column
        GridViewStGroupByCustomerLastName.HeaderRow.Cells[0].Text = " Total ";

        //retrieve data from the database
        dT = clscustomer.StatisticsGroupedByDateAdded();

        //upload dT into Gridview
        GridViewStGroupByDateAdded.DataSource = dT;
        GridViewStGroupByDateAdded.DataBind();

        //change the header of the first column
        GridViewStGroupByDateAdded.HeaderRow.Cells[0].Text = " Total ";
    
    }
}