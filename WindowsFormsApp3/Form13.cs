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
    public partial class Form13 : Form
    {   
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        int id;


        public void DB_Connect()
        {
            String oradb = "DATA SOURCE=DESKTOP-H5PIUV5:1522/orcl2;PERSIST SECURITY INFO=True;USER ID=SCOTT;PASSWORD=tanmay";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        public Form12()
        {
            InitializeComponent();

        }

        private void Form13_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            id = Convert.ToInt32(textBox1.Text);
            new Form11(id).Show();
        }
    }
}
