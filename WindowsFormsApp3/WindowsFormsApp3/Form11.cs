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
    public partial class Form11 : Form
    {
        OracleConnection conn;
        OracleCommand comm;
        OracleDataAdapter da;
        DataSet ds;
        DataTable dt;
        DataRow dr;
        int i = 0;
        int approved = 0;
        public void DB_Connect()
        {
            String oradb = "DATA SOURCE=Aditya-PC:1521/XE;USER ID=SYSTEM;Password=aditya99;";
            conn = new OracleConnection(oradb);
            conn.Open();
        }
        int idd;
        public Form11(int id)
        {
            InitializeComponent();
            idd = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(textBox4.Text);
            String c = comboBox1.Text;
            int p = Convert.ToInt32(textBox5.Text);
            int rating = 0;

            if ((2019 - y) < 1)
            {
                if (c.Equals("Excellent"))
                {
                    rating = 10;
                }
                else if (c.Equals("Very Good"))
                {
                    rating = 9;
                }
                if (c.Equals("Good"))
                {
                    rating = 8;
                }
                if (c.Equals("Average"))
                {
                    rating = 6;
                }
                if (c.Equals("Bad"))
                {
                    rating = 4;
                }
                approved = 1;
            }
            else if ((2019 - y) < 3)
            {
                if (c.Equals("Excellent"))
                {
                    rating = 8;
                }
                else if (c.Equals("Very Good"))
                {
                    rating = 7;
                }
                if (c.Equals("Good"))
                {
                    rating = 6;
                }
                if (c.Equals("Average"))
                {
                    rating = 4;
                }
                if (c.Equals("Bad"))
                {
                    rating = 3;
                }
            }

            else if ((2019 - y) < 5)
            {
                if (c.Equals("Excellent"))
                {
                    rating = 7;
                }
                else if (c.Equals("Very Good"))
                {
                    rating = 6;
                }
                if (c.Equals("Good"))
                {
                    rating = 5;
                }
                if (c.Equals("Average"))
                {
                    rating = 3;
                }
                if (c.Equals("Bad"))
                {
                    rating = 2;
                }
            }

            else if ((2019 - y) < 7)
            {
                if (c.Equals("Excellent"))
                {
                    rating = 6;
                }
                else if (c.Equals("Very Good"))
                {
                    rating = 5;
                }
                if (c.Equals("Good"))
                {
                    rating = 4;
                }
                if (c.Equals("Average"))
                {
                    rating = 3;
                }
                if (c.Equals("Bad"))
                {
                    rating = 2;
                }
            }
            else if ((2019 - y) < 10)
            {
                if (c.Equals("Excellent"))
                {
                    rating = 5;
                }
                else if (c.Equals("Very Good"))
                {
                    rating = 4;
                }
                if (c.Equals("Good"))
                {
                    rating = 3;
                }
                if (c.Equals("Average"))
                {
                    rating = 2;
                }
                if (c.Equals("Bad"))
                {
                    rating = 1;
                }
            }

            else
            {
                if (c.Equals("Excellent"))
                {
                    rating = 4;
                }
                else if (c.Equals("Very Good"))
                {
                    rating = 3;
                }
                if (c.Equals("Good"))
                {
                    rating = 2;
                }
                if (c.Equals("Average"))
                {
                    rating = 1;
                }
                if (c.Equals("Bad"))
                {
                    rating = 0;
                }
            }

            if (rating >= 4) approved = 1;

            if (approved == 0)
            {
                MessageBox.Show("Car Disapproved. Rating : " + rating);
            }
            else
            {
                textBox6.Text = rating.ToString();
                textBox7.Text = ((p / 11) * rating).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (approved == 1)
            {
                DB_Connect();
                OracleCommand c1 = new OracleCommand();


                c1.Connection = conn;








                c1.CommandText = "insert into used_inventory values('" + textBox9.Text + "','" + textBox8.Text + "'," + Convert.ToInt32(textBox11.Text) + ",'" + comboBox2.Text + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "'," + Convert.ToInt32(textBox10.Text) + "," + Convert.ToInt32(textBox6.Text) + "," + Convert.ToInt32(textBox4.Text) + ")";
                c1.CommandType = CommandType.Text;
                c1.ExecuteNonQuery();

                conn.Close();

                MessageBox.Show("Congrats! Your car has been Listed. You will get a phone call when we find a buyer for you.");
                new Form4(Convert.ToInt32(textBox11.Text)).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Car Disapproved.");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Form4(idd).Show();
            this.Hide();
        }
    }
}
