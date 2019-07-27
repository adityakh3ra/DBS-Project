using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form4 : Form
    {
        int idd;
        public Form4(int id)
        {
            InitializeComponent();
            idd = id;
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void buybutton_Click(object sender, EventArgs e)
        {
            new Form5(idd).Show();
            this.Close();
        }

        private void logoutbutton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void sellbutton_Click(object sender, EventArgs e)
        {
            new Form11(idd).Show();
            this.Close();
        }

        private void profilebutton_Click(object sender, EventArgs e)
        {
            new Form13(idd).Show();
            this.Hide();
        }
    }
}
