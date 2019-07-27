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
    
    public partial class Form3 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;

        public Form3()
        {
            InitializeComponent();
        }

        public void DB_Connect()
        {
            String oradb = "DATA SOURCE=Aditya-PC:1521/XE;USER ID=SYSTEM;Password=aditya99;";
            conn = new OracleConnection(oradb);
            conn.Open();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void registerbutton_Click(object sender, EventArgs e)
        {
            DB_Connect();
            OracleCommand c1 = new OracleCommand();
            OracleCommand c2 = new OracleCommand();
            OracleCommand c3 = new OracleCommand();

            c1.Connection = conn;
            c2.Connection = conn;
            c3.Connection = conn;

            c2.CommandText = "select max(id) from login";
            c2.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(c2.CommandText, conn);
            da.Fill(ds, "Login");
            dt = ds.Tables["Login"];
            dr = dt.Rows[0];
            String i = dr["max(id)"].ToString();
            int p = Convert.ToInt32(i);
            p = p + 1;

            c3.CommandText = "insert into login values(" + p + ",'" + textBox5.Text + "')";
            c3.CommandType = CommandType.Text;
            c3.ExecuteNonQuery();

            c1.CommandText = "insert into customer(customer_id, name, address, phone_number, email) values(" + p + ",'" + textBox1.Text + "','" + textBox3.Text + "'," + Convert.ToInt64(textBox2.Text) + ",'" + textBox4.Text + "')";
            c1.CommandType = CommandType.Text;
            c1.ExecuteNonQuery();

             
      

            MessageBox.Show("Your Login ID is:" + p );
            conn.Close();
            new Form2().Show();
            this.Close();
        }
    }
}
