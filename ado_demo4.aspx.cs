using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IBM_Ado_demo
{
    public partial class ado_demo4 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=LAPTOP-QTMJBBT0;Initial Catalog=ibmjune2023;Integrated security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customer", con);

            //Repeater1.DataSource = cmd.ExecuteReader();
            //Repeater1.DataBind();


            DataList1.DataSource = cmd.ExecuteReader();
            DataList1.DataBind();
        }
    }
}