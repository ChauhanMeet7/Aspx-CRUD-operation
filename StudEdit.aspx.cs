using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class StudEdit : System.Web.UI.Page
{
    prc3_b meet = new prc3_b();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            DataSet ds = new DataSet();
            txtsid.Text = Request.QueryString["sid"];
            meet.M_sid = Convert.ToInt64(txtsid.Text);
            ds = meet.prc3_fetch();
            txtsid.Text = ds.Tables[0].Rows[0]["sid"].ToString();
            TextBox2.Text = ds.Tables[0].Rows[0]["sname"].ToString();
            TextBox3.Text = ds.Tables[0].Rows[0]["scity"].ToString();  // Assuming "city" column
            ds.Clear();
            // Optional: Bind GridView for details if needed (document mentions for StudDetAdd)
            meet.D_sid = Convert.ToInt64(txtsid.Text);
            ds = meet.gridview();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
    meet.M_sid = Convert.ToInt64(txtsid.Text);
    meet.M_sname = TextBox2.Text;
    meet.M_scity = TextBox3.Text;
    meet.prc3update();
    Response.Redirect("StudMast.aspx?sid=" + txtsid.Text);

    }
    protected void Button2_Click(object sender, EventArgs e)
    {
     
    meet.M_sid = Convert.ToInt64(txtsid.Text);
    meet.prc3delete();
    Response.Redirect("StudMast.aspx");

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}