using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;

using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;




namespace IBM_Ado_demo
{

    public partial class adodemo1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=LAPTOP-QTMJBBT0;Initial Catalog=ibmjune2023;Integrated security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {         
            con.Open();

            Response.Write("connection success");
        }


        // display all records 
        protected void Button2_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from customer", con);

            GridView2.DataSource= cmd.ExecuteReader();
            GridView2.DataBind();
        }

        // deleting a record
        protected void Button4_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("delete from customer where custid=15", con);
            cmd.ExecuteNonQuery();

            Response.Write("Deletion is success");

        }

        // Insert
        protected void Button3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into customer(custid,custname,city,salary,phone) " +
                "values(1000,'pooja','mysore',20000,787878)", con);
            cmd.ExecuteNonQuery();

            Response.Write("Insertion is success");
        }


        //Update
        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand
            ("update customer " +
            "set custname='prem',city='delhi',salary=200000,phone=878787 where custid=1000" ,con);


            cmd.ExecuteNonQuery();

            Response.Write("Updation is success");
        }
    }
}