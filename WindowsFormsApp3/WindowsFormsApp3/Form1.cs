using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerButton2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
            
        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            new Form2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form9().Show();
            this.Hide();
        }

        }
    }

