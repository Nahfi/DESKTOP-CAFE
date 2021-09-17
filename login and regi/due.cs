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
    public partial class due : Form
    {
        public due()
        {
            InitializeComponent();
            lol();
        }
        void lol()
        {

            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select rr.id as'Coustomer Id',rr.name as 'Coustomer Name',pn as 'Phone Number',city,adress as 'House Number',due from rr join due where rr.id=due.id;";


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

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            MainForm1 registerform = new MainForm1();
            registerform.Show();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Close the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                Application.Exit();
            }

        }

        private void Due_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select rr.id as'Coustomer Id',rr.name as 'Coustomer Name',pn as 'Phone Number',city,adress as 'House Number',due from rr join due where rr.id=due.id;";


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

        private void Button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select * from(select rr.id ,rr.name as 'Coustomer Name',pn as 'Phone Number',city,adress as 'House Number',due from rr join due where rr.id=due.id) as must where must.id='" + this.textBox1.Text + "';";


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
            textBox1.Clear();
            textBox2.Clear();



        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
           // textBox5.Text = selectedRow.Cells[0].Value.ToString();
            textBox1.Text = selectedRow.Cells[0].Value.ToString();

            //textBox3.Text = selectedRow.Cells[2].Value.ToString();
           // textBox2.Text = selectedRow.Cells[3].Value.ToString();
            //textBox4.Text = selectedRow.Cells[4].Value.ToString();

        }
        double t2;
        private void Button3_Click(object sender, EventArgs e)
        {
            string constrin = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";

            string que = "select due from due where id='" + this.textBox1.Text + "';";


            MySqlConnection onDataBase = new MySqlConnection(constrin);
            MySqlCommand cmdDatBase = new MySqlCommand(que, onDataBase);
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

                        t2 = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        //  MessageBox.Show("ok");



                        onDataBase.Close();

                    }
                }
                // MessageBox.Show("YOUR ID is :" + " " + p.ToString() + " ");




            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            if (textBox2.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Amount", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double e1;
                //  double v1;
                double x = double.Parse(textBox2.Text);

                e1 = t2 - x;
                string res = e1.ToString();

                string queee = "update due set due=@textValue      where id='" + this.textBox1.Text + "';";

                MySqlConnection lm = new MySqlConnection(constrin);
                MySqlCommand cmdDataase = new MySqlCommand(queee, lm);
                cmdDataase.Parameters.AddWithValue("@textValue", res);

                MySqlDataReader myReade;


                try
                {
                    lm.Open();
                    myReade = cmdDataase.ExecuteReader();
                    //  MessageBox.Show("updated");
                    while (myReade.Read())
                    {

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                lm.Close();

                //


                string query = "select rr.id as'Coustomer Id',rr.name as 'Coustomer Name',pn as 'Phone Number',city,adress as 'House Number',due from rr join due where rr.id=due.id;";


                MySqlConnection conDataBase = new MySqlConnection(constrin);
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




                //


              
                string querym = "insert into payment(id,amount,datee) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "',@DATE);";

                MySqlConnection conDataBasez = new MySqlConnection(constrin);
                MySqlCommand cmdDataBaseu = new MySqlCommand(querym, conDataBasez);
                MySqlDataReader myReader;
                // cmdDataBaseu.Parameters.AddWithValue("@textValue", cu);
                cmdDataBaseu.Parameters.AddWithValue("@DATE", DateTime.Now);




                try
                {
                    conDataBasez.Open();
                    myReader = cmdDataBaseu.ExecuteReader();
                    //   MessageBox.Show("saved");
                    while (myReader.Read())
                    {

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }











                textBox1.Clear();
                textBox2.Clear();
            }

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            //.Close();
            //this.Hide();

            PAY registerform = new PAY();
            registerform.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 x = new MainForm1();
            x.Show();
        }
    }
}
