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
    public partial class Register_Form : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JAMES\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Window_Project;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataReader dr;
        public Register_Form()
        {
            InitializeComponent();
        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        void clear()
        {
            txt_cpwd.Text = "";
            txt_pwd.Text = "";
            txt_staff_id.Text = "";
            txt_uname.Text = "";
            txt_staff_id.Focus();
        }
        private void button2_Click(object sender, EventArgs e)
        {

            string cpwd = txt_cpwd.Text;
            string pwd = txt_pwd.Text;
            string staff = txt_staff_id.Text;
            string uname = txt_uname.Text;
            if (staff != "" || uname != "" || pwd != "" || cpwd != "")
            {

                if (pwd == cpwd)
                {
                    con.Open();
                    string str = "";
                    str = "Register";
                    cmd = new SqlCommand(str, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Uname", txt_uname.Text);
                    cmd.Parameters.AddWithValue("@Pwd", txt_pwd.Text);
                    cmd.Parameters.AddWithValue("@Cpwd", txt_cpwd.Text);
                    cmd.Parameters.AddWithValue("@Staff_id", txt_staff_id.Text);
                    cmd.ExecuteNonQuery();
                    clear();
                    MessageBox.Show("Successfully Registered");

                    con.Close();
                }
                else
                {
                    MessageBox.Show("Password and Confirm Password does not match");
                }

            }
            else
            {
                MessageBox.Show("Please fill All Information");
            }
        }
    }
}
