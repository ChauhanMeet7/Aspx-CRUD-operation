using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StudMast : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Redirect("StudEdit.aspx?sid=" + GridView1.SelectedRow.Cells[0].Text);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("StudAdd.aspx");
    }
   
}