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
    public partial class Form7 : Form
    {
        int idd;
        public Form7(int id)
        {
            InitializeComponent();
            idd = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go to your nearest showroom and pay.");
            new Form4(idd).Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Go to your nearest showroom and pay by card.");
            new Form4(idd).Show();
            this.Hide();
        }
    }
}
