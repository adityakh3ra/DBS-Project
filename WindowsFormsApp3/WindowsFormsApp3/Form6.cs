using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;

namespace WindowsFormsApp3
{
    public partial class Form6 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        int idd;

        public void DB_Connect()
        {
            String oradb = "DATA SOURCE=Aditya-PC:1521/XE;USER ID=SYSTEM;PASSWORD=aditya99";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        public Form6(int id)
        {
            idd = id;
            InitializeComponent();
            comboBox2.Items.Add("ALL");
            comboBox2.Items.Add("UNDER 10 LAKHS");
            comboBox2.Items.Add("10 TO 20 LAKHS");
            comboBox2.Items.Add("20 TO 30 LAKHS");
            comboBox2.Items.Add("30 TO 40 LAKHS");
            comboBox2.Items.Add("40 TO 50 LAKHS");
            comboBox2.Items.Add("ABOVE 50 LAKHS");

            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select unique(car_make) from new_inventory";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "brand");
            dt = ds.Tables["brand"];
            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "car_make";
            conn.Close();
            DB_Connect();
            comm = new OracleCommand();
            comm.CommandText = "select unique(car_class) from new_inventory";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "ccla");
            dt = ds.Tables["ccla"];
            comboBox3.DataSource = dt.DefaultView;
            comboBox3.DisplayMember = "car_class";
            conn.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string br = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            string pr = this.comboBox2.GetItemText(this.comboBox2.SelectedItem);
            int pr1 = 0;
            int pr2 = 0;
            if (pr.Equals("UNDER 10 LAKHS"))
            {
                pr1 = 0;
                pr2 = 1000000;
            }
            if (pr.Equals("10 TO 20 LAKHS"))
            {
                pr1 = 1000000;
                pr2 = 2000000;
            }
            if (pr.Equals("20 T0 30 LAKHS"))
            {
                pr1 = 2000000;
                pr2 = 3000000;
            }
            if (pr.Equals("30 TO 40 LAKHS"))
            {
                pr1 = 3000000;
                pr2 = 4000000;
            }
            if (pr.Equals("40 TO 50 LAKHS"))
            {
                pr1 = 4000000;
                pr2 = 5000000;
            }
            if (pr.Equals("ABOVE 50 LAKHS"))
            {
                pr1 = 5000000;
                pr2 = 10000000;
            }
            if (pr.Equals("ALL"))
            {
                pr1 = 0;
                pr2 = 10000000;
            }
            string ty = this.comboBox3.GetItemText(this.comboBox3.SelectedItem);
            comm = new OracleCommand();
            comm.CommandText = "select car_make,car_model,price from new_inventory where car_make='" + br + "'and car_class='" + ty + "'and price>=" + pr1 + "and price<" + pr2;
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "ca");
            dt = ds.Tables["ca"];

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            comboBox4.DataSource = dt.DefaultView;
            comboBox4.DisplayMember = "car_model";




            conn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Form5(idd).Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
                        new Form7(idd).Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
