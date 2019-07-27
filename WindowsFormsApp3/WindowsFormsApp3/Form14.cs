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
    public partial class Form14 : Form
    {
        int idd;
        public Form14(int i)
        {
            InitializeComponent();
            idd= i;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form12(idd).Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Form10(idd).Show();
            this.Close();
        }
    }
}
