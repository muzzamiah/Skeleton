﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("1Viewer.aspx");

    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("1Viewer.aspx");
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {

    }
}