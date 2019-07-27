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
            String oradb = "DATA SOURCE=Aditya-PC:1521/XE;USER ID=SYSTEM;PASSWORD=aditya99";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        public Form13(int id)
        {
            InitializeComponent();
            this.id = id;

            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from customer where customer_id =" + id;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "brand");
            dt = ds.Tables["brand"];
            dr = dt.Rows[i];
            textBox1.Text = dr["customer_id"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["address"].ToString();
            textBox4.Text = dr["phone_number"].ToString();
            textBox5.Text = dr["email"].ToString();

            conn.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form13(id).Show();
            this.Hide();
        }
    }
}
