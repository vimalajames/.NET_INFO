using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Windows_Project.Commonclass
{
    class common
    {

        public void connection()
        {
            SqlConnection con = new SqlConnection("Data Source=JAMES\\SQLEXPRESS;Integrated Security=True;Initial Catalog=Window_Project;");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            SqlDataReader dr;
        
        }

       
    }
}
