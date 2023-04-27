﻿using System;
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
    public partial class Form2 : Form
    {
        string softconn = "Data Source=orcl;User Id=hr;Password=HR;";
        OracleConnection conn;
        OracleDataAdapter adapter;
        OracleCommandBuilder builder;
        DataSet ds;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string cmdstr = "select * from organizer ";

            adapter = new OracleDataAdapter(cmdstr, softconn);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }
    }
}