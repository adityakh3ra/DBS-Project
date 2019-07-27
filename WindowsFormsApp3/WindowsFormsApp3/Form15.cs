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
    public partial class Form15 : Form
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
        public Form15()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connect();
            string br = this.comboBox1.GetItemText(this.comboBox1.SelectedItem);
            comm = new OracleCommand();
            comm.CommandText = "select * from used_inventory where car_class='" + br+"'";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "ca");
            dt = ds.Tables["ca"];

            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            conn.Close();
        }
    }
}
