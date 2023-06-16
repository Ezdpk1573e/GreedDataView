using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace GreedDataView
{
    public partial class Greed_Form : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            DataSet s1 = new DataSet();
            DataTable ta = new DataTable();
            ta.Columns.Add("Student Name");
            ta.Columns.Add("Father Name");
            ta.Columns.Add("Mother Name");
            ta.Columns.Add("Address");
            ta.Columns.Add("City");
            ta.Rows.Add(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text);
            s1.Tables.Add(ta);
            GridView1.DataSource = s1.Tables[0];
            GridView1.DataBind();

        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string q = "insert into Greed values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "')";
            SqlConnection cn = new SqlConnection(@"Data Source=DEV;Initial Catalog=Greed View;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Data Submited Successfully.....");
            }
            else
            {
                Response.Write("Data Not Submited.....");
            }

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}