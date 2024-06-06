using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Windows_Project
{
    public partial class Stu_Personal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JAMES\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Window_Project;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
       // SqlDataReader dr;
        Staff_Personal obj = new Staff_Personal();
        public Stu_Personal()
        {
            InitializeComponent();
        }
        public void para()
        {
            cmd.Parameters.AddWithValue("@staff_id", txt_ID.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@age", txt_age.Text);
            cmd.Parameters.AddWithValue("@address", rtxt_address.Text);
            cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@Doj", date_doj.Text);
            cmd.Parameters.AddWithValue("@blood", combo_blood.Text);


        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                Staff_Personal obj = new Staff_Personal();
                con.Open();
                string str = "";
                str = "Student_Personal";
                cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@status", "Add");
                para();
                cmd.ExecuteNonQuery();
                obj.clear();
                con.Close();
            }
            catch(Exception  ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
       
       
        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "";
            str = "Student_Personal";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "Update");
            obj. para();
            cmd.ExecuteNonQuery();
            obj.clear();
            con.Close();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "";
            str = "select * from Stu_personal";
            da = new SqlDataAdapter(str, con);
            ds.Clear();
            da.Fill(ds);
            grid_view.DataSource = ds.Tables[0].DefaultView;
                        con.Close();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "";
            str = "Student_Personal";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "Delete");
            obj. para();
            cmd.ExecuteNonQuery();
            obj. clear();
            con.Close();
        }
    }
}
