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
    public partial class staff_salary : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JAMES\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Window_Project;");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        SqlDataReader dr;
        public staff_salary()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            int gross = Convert.ToInt32(txt_grosssalary.Text);
            
            float Leave = Convert.ToInt32(txt_leave.Text);
            //Leave Calculation

            float one_day_sal = gross / 30;
            float tot_leave_amt =one_day_sal*Leave;
            

            //PF Condition Checking
            float pf;
            if(gross>=50000)
            {
                 pf =( gross * 12 )/ 100;
                txt_pf.Text =Convert.ToString(pf);
                
            }
            else if(gross>=20000)
            {
                 pf = (gross *8) / 100;
                txt_pf.Text = Convert.ToString(pf);
               
            }
           else if(gross>=10000)
            {
                 pf = (gross *5) / 100;
                txt_pf.Text = Convert.ToString(pf);
               
            }
            else
            {
                 pf = 0;
                txt_pf.Text = Convert.ToString(pf);
                MessageBox.Show(pf.ToString());
            }
            //Net Salary calculation
            float net_sal = gross - tot_leave_amt - pf;
            txt_netsalary.Text = Convert.ToString(net_sal);

        }
        void Clear()
        {
            txt_staff_id.Text = "";
            txt_pf.Text = "";
            txt_netsalary.Text = "";
            txt_name.Text = "";
            txt_leave.Text = "";
            txt_grosssalary.Text = "";
            txt_staff_id.Focus();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "";
            str = "Staff_salary";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@staff_id",txt_staff_id.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@gross",txt_grosssalary.Text);
            cmd.Parameters.AddWithValue("@leave",txt_leave.Text);
            cmd.Parameters.AddWithValue("@pf", txt_pf.Text);
            cmd.Parameters.AddWithValue("@net", txt_netsalary.Text);
            cmd.ExecuteNonQuery();
            Clear();
            MessageBox.Show("Added Successfully");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "getsalary";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", txt_staff_id.Text);
            dr = cmd.ExecuteReader();
            if (dr.HasRows==true)
            {
                dr.Read();
                
                    txt_staff_id.Text = dr["Staff_Id"].ToString();
                    txt_pf.Text = dr["PF"].ToString();
                    txt_name.Text = dr["Name"].ToString();
                    txt_grosssalary.Text = dr["Gross_Salary"].ToString();
                    txt_netsalary.Text = dr["Net_Salary"].ToString();
                    txt_leave.Text = dr["LeaveDays"].ToString();
                
                dr.Close();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }




            con.Close();
        }
    }
}
