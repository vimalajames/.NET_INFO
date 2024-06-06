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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JAMES\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Window_Project;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataReader dr;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register_Form obj = new Register_Form();
            obj.Show();
        }
          
                
        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                string uname = txt_uname.Text;
                string pwd = txt_pwd.Text;
                if (uname == "" || pwd == "")
                {
                    MessageBox.Show("Please Enter the UserName & Password");
                }
                else
                {
                    con.Open();
                    string str = "";
                    str = "checklog";
                    cmd = new SqlCommand(str, con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@uname", txt_uname.Text);
                    cmd.Parameters.AddWithValue("@pwd", txt_pwd.Text);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    int count = int.Parse(dr[0].ToString());
                    if (count >= 1)
                    {

                        Home obj = new Home();
                        obj.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Username or Password");
                    }
                                              

                    con.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "";
            str = "select * from Register_Login";
            da = new SqlDataAdapter(str, con);
            ds.Clear();
            da.Fill(ds);
            grid_view.DataSource = ds.Tables[0].DefaultView;
            

            con.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txt_pwd.UseSystemPasswordChar = false;
            }
            else
            {
                txt_pwd.UseSystemPasswordChar = true;
            }
        }
    }
}
