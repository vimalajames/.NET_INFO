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
    public partial class Marks : Form
    {
        SqlConnection con = new SqlConnection("Data Source=JAMES\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Window_Project;");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public Marks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string str = "";
            str = "stu_marks";
            cmd = new SqlCommand(str, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@status", "Add");
            para();
            cmd.ExecuteNonQuery();
            clear();
            con.Close();
        }
        public void para()
        {
            
            cmd.Parameters.AddWithValue("@ad_no",txt_adno.Text);
            cmd.Parameters.AddWithValue("@name", txt_name.Text);
            cmd.Parameters.AddWithValue("@class",combo_class.Text);
            cmd.Parameters.AddWithValue("@section",combo_section.Text);
            cmd.Parameters.AddWithValue("@tamil",txt_tamil.Text);
            cmd.Parameters.AddWithValue("@english",txt_eng.Text);
            cmd.Parameters.AddWithValue("@maths", txt_maths.Text);
            cmd.Parameters.AddWithValue("@science",txt_sci.Text);
            cmd.Parameters.AddWithValue("@social",txt_social.Text);
            cmd.Parameters.AddWithValue("@total",txt_tot.Text);
            cmd.Parameters.AddWithValue("@avg",txt_avg.Text);
        }
        void calc()
        {
            int tamil = Convert.ToInt32(txt_tamil.Text);
            int eng = Convert.ToInt32(txt_eng.Text);
            int maths = Convert.ToInt32(txt_maths.Text);
            int sci = Convert.ToInt32(txt_sci.Text);
            int social = Convert.ToInt32(txt_social.Text);
            int total = tamil + eng + maths + sci + social;
             txt_tot.Text = total.ToString();
            double avg = total / 5;
            txt_avg.Text =avg.ToString();

        }
        void clear()
        {
            txt_adno.Text = "";
            txt_name.Text = "";
            combo_class.Text = "";
            combo_section.Text = "";
            txt_tamil.Text = "";
            txt_eng.Text = "";
            txt_maths.Text = "";
            txt_sci.Text = "";
            txt_social.Text = "";
            txt_tot.Text = "";
            txt_avg.Text = "";
            txt_adno.Focus();

        }
        private void btn_calculate_Click(object sender, EventArgs e)
        {
            calc();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                string str = "";
                str = "getMarks";
                cmd = new SqlCommand(str, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", txt_adno.Text);
                dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        txt_adno.Text = dr["Ad_No"].ToString();
                        txt_name.Text = dr["Name"].ToString();
                        combo_class.Text = dr["Class"].ToString();
                        combo_section.Text = dr["Section"].ToString();
                        txt_tamil.Text = dr["Tamil"].ToString();
                        txt_eng.Text = dr["English"].ToString();
                        txt_maths.Text = dr["Maths"].ToString();
                        txt_sci.Text = dr["Science"].ToString();
                        txt_social.Text = dr["Social"].ToString();
                        txt_tot.Text = dr["Total"].ToString();
                        txt_avg.Text = dr["Average"].ToString();

                    }
                    dr.Close();
                }

                else
                {
                    MessageBox.Show("No Data Found");
                }

                con.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }     
}
