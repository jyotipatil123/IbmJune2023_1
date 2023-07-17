using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IBM_Ado_demo
{
    public partial class grid_with_linq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string[] arr = new string[3] { "anita", "sunita", "kavita" };

            var query = from emp in arr
                        select emp;


            if (query.Count() > 0)
            {
                GridView1.DataSource = query;
                GridView1.DataBind();
            }

            //=======================================================

            SqlConnection con = new SqlConnection("Data source=LAPTOP-QTMJBBT0;Initial Catalog=ibmjune2023;Integrated security=True");
            con.Open();

            DataClasses1DataContext custcontext = new DataClasses1DataContext(con);

            var query1 = from c in custcontext.customers
                         where c.custid >= 20
                         select c;


            if (query1.Count() > 0)
            {
                GridView1.DataSource = query1;
                GridView1.DataBind();
            }
        }
    }
}