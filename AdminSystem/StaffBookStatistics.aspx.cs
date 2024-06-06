using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class StaffBookStatistics : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsStaff clsstaff = new clsStaff();
        DataTable dt = clsstaff.StatisticsGroupedByDateAdded();
        GridViewStGroupByDateAdded.DataSource = dt;
        GridViewStGroupByDateAdded.DataBind();

        GridViewStGroupByDateAdded.HeaderRow.Cells[0].Text = "Total?";
    }

    protected void GridViewStGroupByDateAdded_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}