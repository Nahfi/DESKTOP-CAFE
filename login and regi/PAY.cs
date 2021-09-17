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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;





namespace login_and_regi
{
    public partial class PAY : Form
    {
        public PAY()
        {
            InitializeComponent();
            alsa();
            //cuu();
        }
        void alsa()
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "SELECT payment.id,rr.name,payment.amount,payment.datee FROM payment join rr WHERE rr.id=payment.id;";


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

            due registerform = new due();
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

        private void PAY_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "SELECT payment.id,rr.name,payment.amount,payment.datee FROM payment join rr WHERE rr.id=payment.id;";


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

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            MainForm1 registerform = new MainForm1();
            registerform.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select * from(SELECT payment.id,rr.name,payment.amount,payment.datee FROM payment join rr WHERE rr.id=payment.id) as must where must.id='" + this.textBox5.Text + "';";


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
            textBox5.Clear();
         //   textBox2.Clear();


        }
        public void ex(DataGridView dgw,string filename)
        {



        }
       
        private void Button2_Click(object sender, EventArgs e)
        {

           // exportgridtopdf(dataGridView1, "test");
                    }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
