using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace IBM_Ado_demo
{
    public partial class ado_demo3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection("Data source=LAPTOP-QTMJBBT0;Initial Catalog=ibmjune2023;Integrated security=True");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //  insertion 
        protected void Button1_Click(object sender, EventArgs e)
        {
            inspanel.Visible=true;
            delpanel.Visible = false;
            updatepanel.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            inspanel.Visible = false;
            delpanel.Visible = true;
            updatepanel.Visible = false;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            inspanel.Visible = false;
            delpanel.Visible = false;
            updatepanel.Visible = true;
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            con.Open();

            int cid1 = int.Parse(TXTCUSTID.Text);


            SqlCommand cmd = new SqlCommand("delproc", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@cid", SqlDbType.Int).Value = cid1;
                

            cmd.ExecuteNonQuery();

            Response.Write("Deletion is success");
        }
    }
}

// create below stored procedures in SQL
//Insertion:

//create proc insproc
//(@cid int, @cname varchar(50), @city1 varchar(50), @sal int, @ph int)
//as
//begin
//   insert into customer(custid, custname, city, salary, phone)
//   values(@cid, @cname, @city1, @sal, @ph)
//end
//===========================================================================================
//Deletion : 

//create proc delproc
//(@cid int)
//as
//begin
//  delete from customer where custid=@cid
//end
//==================================================================================================
//Updation : 

//create proc updateproc
//(@cid int, @cname varchar(50), @city1 varchar(50) , @sal int, @ph int)
//as
//begin
//   update customer set custname=@cname,city=@city1,
//   salary=@sal, phone=@ph where custid=@cid
//end