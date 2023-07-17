using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using System.Data;
using System.Data.SqlClient;
using System.Xml;


namespace IBM_Ado_demo
{
    public partial class datareaderdemo : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=LAPTOP-QTMJBBT0;Initial Catalog=ibmjune2023;Integrated security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //sqldata reader
        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customer", con);
            SqlDataReader rdr= cmd.ExecuteReader();

            while (rdr.Read())
            {
                Response.Write(rdr[0]+"   " + rdr[1] +"</br>");               
            }

            //or

            while (rdr.Read())
            {
                Response.Write(rdr["id"] + "   " + rdr["name"] + "</br>");
            }


        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlDataAdapter ad = new SqlDataAdapter("select * from customer", con);

            DataSet ds = new DataSet();
            ad.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }
    }
}