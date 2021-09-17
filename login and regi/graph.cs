using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace login_and_regi
{
    public partial class graph : Form
    {
        public graph()
        {
            InitializeComponent();
            dull();
        }
        void dull()
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select id  as 'COUSTOMER ID', name as'COUSTOMER NAME',city, pnum as 'PHONE NUMBER',total as 'TOTAL SELL',datee from tot where id !=101;";


            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);




            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Graph_Load(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select id  as 'COUSTOMER ID', name as'COUSTOMER NAME',city, pnum as 'PHONE NUMBER',total as 'TOTAL SELL',datee from tot where id !=101;";


            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);




            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }

        private void Label8_Click(object sender, EventArgs e)
        {
            // this.Close();
            this.Hide();

            transaction registerform = new transaction();
            registerform.Show();

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Label8_Click_1(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide();

            transaction registerform = new transaction();
            registerform.Show();

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Close the Application?","Exit",MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                Application.Exit();
            }
           

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            //string query = "select id  as 'COUSTOMER ID', name as'COUSTOMER NAME',city, pnum as 'PHONE NUMBER',total as 'TOTAL SELL',datee from tot where datee between '" + this.dateTimePicker1.Text + "' and '" + this.dateTimePicker2.Text + "' ;";
            string query = "SELECT datee, sum(total)as total FROM tot GROUP by datee HAVING datee BETWEEN '" + this.dateTimePicker1.Text + "'  and '" + this.dateTimePicker2.Text + "'; ";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbdataset);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        double a;
        private void Button3_Click(object sender, EventArgs e)
        {
            /*int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            MessageBox.Show(sum.ToString());*/


            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            //  string que = "select quantity from product where id='" + this.textBox5.Text + "';";
            string query = "SELECT sum(total)as total FROM tot where datee BETWEEN '" + this.dateTimePicker1.Text + "'  and '" + this.dateTimePicker2.Text + "'; ";


            MySqlConnection onDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatBase = new MySqlCommand(query, onDataBase);
            MySqlDataReader Reader;
            string SUM;

            try
            {
                onDataBase.Open();
                Reader = cmdDatBase.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Reader.HasRows)

                {
                    if (Reader.Read())
                    {
                        //string mystring;

                        SUM = Reader.GetString(0);

                        a = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                         MessageBox.Show("TOTAL SELL BETWEEN THESE DATE IS: " + a);



                        onDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        string s;
        private void Button4_Click(object sender, EventArgs e)
        {

            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            //  string que = "select quantity from product where id='" + this.textBox5.Text + "';";
            string query = "select avg (x) from (SELECT sum(total)as x FROM tot group by datee having  datee BETWEEN '" + this.dateTimePicker1.Text + "'  and '" + this.dateTimePicker2.Text + "') as m; ";


            MySqlConnection onDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatBase = new MySqlCommand(query, onDataBase);
            MySqlDataReader Reader;
            string SUM;

            try
            {
                onDataBase.Open();
                Reader = cmdDatBase.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Reader.HasRows)

                {
                    if (Reader.Read())
                    {
                        //string mystring;

                        SUM = Reader.GetString(0);

                        a = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);

                       /* DateTime inTime = Convert.ToDateTime(dateTimePicker1.Text);
                        DateTime outTime = Convert.ToDateTime(dateTimePicker2.Text);
                        if (outTime >= inTime)
                        {
                            s = outTime.Subtract(inTime).Days.ToString();
                        }
                        MessageBox.Show("TOTAL SELL BETWEEN THESE DATE IS: " + s);
                        */
                        MessageBox.Show("AVARAGE SELL BETWEEN THESE DATE IS: " + a);



                        onDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            /*double sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            DateTime x = dateTimePicker1.Value.Date;
            DateTime y = dateTimePicker2.Value.Date;
            TimeSpan z = x - y;
            double c = z.Days;

            if (c == 0)
            {
                MessageBox.Show("NO AVERAGE" +
                    "");

            }
            else
            {
                double avg = sum / c;
                double abs2 = Math.Abs(avg);


                MessageBox.Show(abs2.ToString());
            }*/

        }

        private void Button5_Click(object sender, EventArgs e)
        {


            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            // string query = "select sum(total) as total  from tot group by datee having datee between '" + this.dateTimePicker1.Text + "' and '" + this.dateTimePicker2.Text + "';";
            string query = "SELECT datee, sum(total)as total FROM tot GROUP by datee HAVING datee BETWEEN '" + this.dateTimePicker1.Text + "'  and '" + this.dateTimePicker2.Text + "'; ";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                //   MessageBox.Show("saved");
                while (myReader.Read())
                {
                    this.chart1.Series["Total Sell"].Points.AddXY(myReader.GetString("datee"), myReader.GetInt32("total"));
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void Chart1_Click(object sender, EventArgs e)
        {

        }
    }
}