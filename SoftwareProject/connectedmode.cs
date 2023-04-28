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
            OracleCommand sel = new OracleCommand();
            sel.CommandText = "GetEventName";
            sel.CommandType = CommandType.StoredProcedure;
            sel.Parameters.Add("events", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr2 = sel.ExecuteReader();
            while (dr2.Read())
            {
                comboBox1.Items.Add(dr2[0]);
            }
            dr2.Close();

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
            int max_id, new_id;
            OracleCommand pro = new OracleCommand();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            pro.Connection = con;
            pro.CommandText = "GetTicketId";
            pro.CommandType = CommandType.StoredProcedure;
            pro.Parameters.Add("ticket_id",OracleDbType.Int32,ParameterDirection.Output);
            pro.ExecuteNonQuery();
            try
            {
                max_id = Convert.ToInt32(pro.Parameters["ticket_id"].Value.ToString());
                new_id = max_id++;
            }
            catch
            {
                new_id = 1;
            }
            cmd.CommandText = "insert into ticket values(:id,:event_id,:organizer_id)";
            cmd.Parameters.Add("id", new_id);
            cmd.Parameters.Add("event_id", comboBox1.Text);
            cmd.Parameters.Add("organizer_id", idbox.Text);
            int r = cmd.ExecuteNonQuery();
            if(r!= -1)
            {
                ticketbox.Text = new_id.ToString();
                MessageBox.Show("BOOKED...");
            }
        }
    }
}
