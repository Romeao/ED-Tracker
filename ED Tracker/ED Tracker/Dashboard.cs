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

namespace ED_Tracker
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\EDTrackerdatabase.mdf;Integrated Security=True;Connect Timeout=30");

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(255, 106, 61);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
                this.WindowState = FormWindowState.Minimized;
       
            
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            label4.ForeColor = Color.FromArgb(244, 219, 125);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(255, 106, 61);
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(244, 219, 125);
        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            loginform log = new loginform();
            this.Hide();
            log.Show();
        }


    }
}
