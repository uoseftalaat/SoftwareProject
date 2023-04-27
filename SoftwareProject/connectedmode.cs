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


namespace SoftwareProject
{
   

   
   
    public partial class connectedmode : Form
    {
        string constr = "Data Source=orcl;User Id=hr;Password=HR;";
        OracleConnection con;

        public connectedmode()
        {
            InitializeComponent();
        }
















        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void connectedmode_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(); ‏
            con.Open();
            
           

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             ‏OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "select date_,price from event where name=:event_name";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("event_name", comboBox1.SelectedItem.ToString());


            OracleDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                datebox.Text = dr[0].ToString();
                pricebox.Text = dr[1].ToString();
            }
            dr.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into ticket values(:id,:event_id,:organizer_id)";
            cmd.Parameters.Add("id", cmb_ID.Text);
            cmd.Parameters.Add("event_id", comboBox1.Text);
            cmd.Parameters.Add("organizer_id", idbox.Text);
            int r = cmd.ExecuteNonQuery();
            if(r!= -1)
            {
                //show ticket id
                MessageBox.Show("BOOKED...");
            }
        }
    }
}
