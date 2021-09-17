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
    public partial class transaction : Form
    {
        public transaction()
        {
            InitializeComponent();
            lul();
            chul();
        }




        void chul()
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
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }




        void lul()
        {




            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select name as'COUSTOMER NAME',city, phn as 'PHONE NUMBER',pid as'PRODUCT ID' ,pname as 'PRODUCT NAME' ,qunatity,sell,datee from lol where id!=101;";


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
        private void Button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select name as'COUSTOMER NAME',city, phn as 'PHONE NUMBER',pid as'PRODUCT ID' ,pname as 'PRODUCT NAME' ,qunatity,sell,datee from lol where id!=101;";


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

        }

        private void Label2_Click(object sender, EventArgs e)
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
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            textBox1.Clear();

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            MainForm1 registerform = new MainForm1();
            registerform.Show();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainform = new MainForm1();
            mainform.Show();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Close the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                Application.Exit();
            }

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select name as'COUSTOMER NAME',city, phn as 'PHONE NUMBER',pid as'PRODUCT ID' ,pname as 'PRODUCT NAME' ,qunatity,sell,datee from lol where id!=101 and name= '" + this.textBox1.Text + "';";


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

            string quer = "select id  as 'COUSTOMER ID', name as'COUSTOMER NAME',city, pnum as 'PHONE NUMBER',total as 'TOTAL SELL',datee from tot where id !=101 and name='" + this.textBox1.Text + "';";


            MySqlConnection coDataBase = new MySqlConnection(constring);
            MySqlCommand cmDataBase = new MySqlCommand(quer, coDataBase);




            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmDataBase;
                DataTable dbdataset = new DataTable();
                sda.Fill(dbdataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbdataset;
                dataGridView2.DataSource = bSource;
                sda.Update(dbdataset);



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            textBox1.Clear();


        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            graph x = new graph();
            x.Show();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            tu x = new tu();
            x.Show();
        }
    }
    
}
