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

namespace GRE_Counter
{
    public partial class ChangeDate : Form
    {
        public ChangeDate()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Date.mdf;Integrated Security=True;User Instance=True");
            public DateTime time1;
            Date_Calender.SelectionRange.Start = time1;
        }

        private void CB_ok_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Date.mdf;Integrated Security=True;User Instance=True");
            SqlCommand cmd = new SqlCommand("sp_insert", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", ChangeDate.Date_Calender.SelectionRange.Start);
            con.Open();

        }
    }
}
