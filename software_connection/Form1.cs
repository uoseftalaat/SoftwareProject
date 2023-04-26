using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;


namespace software_connection
{
    public partial class Form1 : Form
    {
        string softconn = "Data source=orcl; User Id =hr; Password=HR;"; ‏
        OracleConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select Id from ORGANIZER";
            OracleDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {

                comboBox1.Items.Add(dr[0]); ‏
   
            }
            dr.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            conn = new OracleConnection(softconn);
            conn.Open();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
