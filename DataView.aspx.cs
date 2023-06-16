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
    public partial class DataView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string q = "select * from Greed";
            SqlConnection cn = new SqlConnection(@"Data Source=DEV;Initial Catalog=Greed View;Integrated Security=True");
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(q, cn);
            DataSet ds = new DataSet();
            da.Fill(ds);

            GridView1.DataSource = ds;
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string id = GridView1.Rows[e.RowIndex].Cells[0].Text;
            TextBox n =(TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];
            TextBox f = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];
            TextBox m = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];
            TextBox a = (TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0];
            TextBox c = (TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0];

            string up = "update Greed set Student_Name='" + n.Text + "',Father_Name='" + f.Text + "',Mother_Name='" + m.Text + "',Address='" + a.Text + "',City='" + c.Text + "' Where id=" + id;
            SqlConnection cn = new SqlConnection(@"Data Source=DEV;Initial Catalog=Greed View;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(up, cn);
            cmd.ExecuteNonQuery();

            GridView1.EditIndex = -1;
            Button1_Click(sender, e);

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Button1_Click(sender, e);
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            Button1_Click(sender, e);

        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.Rows[e.RowIndex].Cells[0].Text;
            string q = "delete from Greed where id=" + id;
            SqlConnection cn = new SqlConnection(@"Data Source=DEV;Initial Catalog=Greed View;Integrated Security=True");
            cn.Open();
            SqlCommand cmd = new SqlCommand(q, cn);
            cmd.ExecuteNonQuery();

            GridView1.EditIndex = -1;
            Button1_Click(sender, e);
        }
    }
}