using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareProject
{
    public partial class general : Form
    {
        public general()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void user_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void user_Click(object sender, EventArgs e)
        {
            connectedmode c = new connectedmode();
            c.Show();
            this.Hide();
        }

        private void admin_Click(object sender, EventArgs e)
        {
            Form2 c = new Form2();
            c.Show();
            this.Hide();
        }
    }
}
