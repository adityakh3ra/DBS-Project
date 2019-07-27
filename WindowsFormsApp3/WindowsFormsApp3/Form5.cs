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
    public partial class Form5 : Form
    {
        int idd; 
        public Form5(int id)
        {
            InitializeComponent();
            idd = id;
        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            new Form6(idd).Show();
            this.Close();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new Form4(idd).Show();
            this.Close();
        }

        private void usedbutton_Click(object sender, EventArgs e)
        {
            new Form15().Show();
            this.Hide();
        }
    }
}
