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
    public partial class Form12 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        int id;

        int idd;
        public void DB_Connect()
        {
            String oradb = "DATA SOURCE=Aditya-PC:1521/XE;USER ID=SYSTEM;PASSWORD=aditya99";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        public Form12(int id)
        {
            InitializeComponent();
            idd = id;
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from salary" ;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "brand");
            dt = ds.Tables["brand"];
            dr = dt.Rows[i];
            textBox1.Text = dr["BASE_SALARY"].ToString();
            textBox2.Text = dr["COMMISSION1"].ToString();
            textBox3.Text = dr["FINAL_SALARY"].ToString();
            conn.Close();

     

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form14(idd).Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }
    }
}