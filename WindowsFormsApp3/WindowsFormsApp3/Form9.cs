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
using System.Data.Common;
using System.Data.SqlClient;

namespace WindowsFormsApp3
{
    public partial class Form9 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Form9()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "DATA SOURCE=Aditya-PC:1521/XE;USER ID=SYSTEM;Password=aditya99;";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void Passlabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from elogin";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "eLogin");
            dt = ds.Tables["eLogin"];
            int z = dt.Rows.Count;
            int f = 0;
            //Console.WriteLine(z);
            for (int i = 0; i < z; i++)
            {
                dr = dt.Rows[i];
                String id = dr["id"].ToString();
                String pass = dr["password"].ToString();
                if (textBox1.Text.Equals(id) && textBox2.Text.Equals(pass))
                {
                    new Form14(Convert.ToInt32(id)).Show();
                    this.Hide();
                    f = 1;
                    break;
                }
            }
            if (f == 0)
                MessageBox.Show("Wrong Id or Password");


            conn.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }
    }
}
