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
    public partial class Form10 : Form
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
            String oradb = "DATA SOURCE=Aditya-PC:1521/XE;USER ID=SYSTEM;PASSWORD=aditya99;";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        public Form10(int id)
        {
            InitializeComponent();

            this.id = id;

            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select * from employee where employee_id =" + id;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "brand");
            dt = ds.Tables["brand"];
            dr = dt.Rows[i];
            textBox1.Text = dr["employee_id"].ToString();
            textBox2.Text = dr["name"].ToString();
            textBox3.Text = dr["designation"].ToString();
            textBox4.Text = dr["address"].ToString();
            textBox5.Text = dr["phone_number"].ToString();
            textBox6.Text = dr["email"].ToString();
            textBox7.Text = dr["department_id"].ToString();
            textBox8.Text = dr["work_shift"].ToString();
            conn.Close();






        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
