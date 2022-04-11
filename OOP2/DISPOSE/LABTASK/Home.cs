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

namespace LABTASK
{
    public partial class Home : Form
    {

        SqlConnection sqlCon = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\student\Desktop\SampleManagementSystem\fallsampledb.mdf;Integrated Security=True;Connect Timeout=30");

        public Home()
        {
            InitializeComponent();
        }

        private void button_show_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Login";
            sqlCon.Open();
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlCon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            sqlCon.Close();
        }
    }
}
