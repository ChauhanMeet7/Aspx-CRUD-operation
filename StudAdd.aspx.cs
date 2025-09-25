using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.WebControls.WebParts;

public partial class StudAdd : System.Web.UI.Page
{
    prc3_b meet = new prc3_b();

    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        meet.M_sname = txtname.Text;
        meet.M_scity = txtcity.Text;
        meet.M_sid = Convert.ToInt64(textsid.Text); ;
        meet.prc3_add();			
        Response.Redirect("StudMast.aspx");
    }
}