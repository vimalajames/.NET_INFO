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
    public partial class Staff_Personal : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JAMES\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Window_Project;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataReader dr;
        public Staff_Personal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void para()
         {
            cmd.Parameters.AddWithValue("@staff_id", txt_ID.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@age",txt_age.Text);
            cmd.Parameters.AddWithValue("@address",rtxt_address.Text);
            cmd.Parameters.AddWithValue("@phone", txt_phone.Text);
            cmd.Parameters.AddWithValue("@email", txt_email.Text);
            cmd.Parameters.AddWithValue("@Doj", date_doj.Text);
            cmd.Parameters.AddWithValue("@blood",combo_blood.Text);
            

         }



        public void clear()
        {
            txt_age.Text = "";
            txt_email.Text = "";
            txt_name.Text = "";
            txt_phone.Text = "";
            txt_ID.Text = "";
            rtxt_address.Text = "";
            date_doj.Text = "";
            combo_blood.Text = "";
            txt_ID.Focus();
        }
        public void Add()
        {
            con.Open();
            string str = "";
            str = "personal";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "Add");
            para();
            cmd.ExecuteNonQuery();
            clear();
            con.Close();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            Add();
        }

        public void View()
        {
            con.Open();
            string str = "";
            str = "select * from staff_personal";
            da = new SqlDataAdapter(str, con);
            ds.Clear();
            da.Fill(ds);
            grid_view.DataSource = ds.Tables[0].DefaultView;

            con.Close();
        }
        private void btn_view_Click(object sender, EventArgs e)
        {
            View();
        }
        public void Update()
        {
            con.Open();
            string str = "";
            str = "personal";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "Update");
            para();
            cmd.ExecuteNonQuery();
            clear();
            con.Close();
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            Update();
        }
        public void Delete()
        {
            con.Open();
            string str = "";
            str = "personal";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "Delete");
            para();
            cmd.ExecuteNonQuery();
            clear();
            con.Close();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Staff_Personal_Load(object sender, EventArgs e)
        {

        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (!char.IsLetterOrDigit(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' && e.KeyChar != '-')
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
    }
}
