using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IBM_Ado_demo
{
    public partial class ado_demo2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=LAPTOP-QTMJBBT0;Initial Catalog=ibmjune2023;Integrated security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Insert panel
        protected void Button1_Click(object sender, EventArgs e)
        {
            InsPanel.Visible= true;
            DelPanel.Visible = false;
            UpdatePanel.Visible = false;
        }


        // Delete panel
        protected void Button2_Click(object sender, EventArgs e)
        {
            InsPanel.Visible = false;
            DelPanel.Visible = true;
            UpdatePanel.Visible = false;
        }

        //
        // Update panel
        protected void Button3_Click(object sender, EventArgs e)
        {
            InsPanel.Visible = false;
            DelPanel.Visible = false;
            UpdatePanel.Visible = true;
        }


        //Deletion 
        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from customer where custid='"+int.Parse(txtcustid1.Text)+"'   ", con);
            cmd.ExecuteNonQuery();

            Response.Write("Deletion is success");

        }

        protected void Button5_Click(object sender, EventArgs e)
        {

        }
    }
}