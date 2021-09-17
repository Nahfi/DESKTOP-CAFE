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
    public partial class ADD : Form
    {
        public ADD()
        {
            InitializeComponent();
            tunu();
        }
         void tunu()
        {


            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select id as'Product Id',name as 'Product Name',quantity,price as 'ORGINAL PRICE PP',sell as 'SELLING PRICE PP'  from product;";

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

        }

        private void ADD_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

           




        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select id as'Product Id',name as 'Product Name',quantity,price as 'ORGINAL PRICE PP',sell as 'SELLING PRICE PP'  from product;";

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

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "insert into product(name,quantity,price,sell) values('" + this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox2.Text + "','" + this.textBox4.Text + "');";

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

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            string uery = "select id as'Product Id',name as 'Product Name',quantity,price as 'ORGINAL PRICE PP',sell as 'SELLING PRICE PP'  from product;";

            MySqlConnection conDataBas = new MySqlConnection(constring);
            MySqlCommand cmdDataBas = new MySqlCommand(uery, conDataBas);


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBas;
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
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "DELETE from product  where id='" + this.textBox5.Text + "';";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
             //   MessageBox.Show("DELETETED");
                while (myReader.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            string uery = "select id as'Product Id',name as 'Product Name',quantity,price as 'ORGINAL PRICE PP',sell as 'SELLING PRICE PP'  from product;";

            MySqlConnection conDataBas = new MySqlConnection(constring);
            MySqlCommand cmdDataBas = new MySqlCommand(uery, conDataBas);


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBas;
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
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();


        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "update product set quantity='" + this.textBox3.Text + "',price='" + this.textBox2.Text + "' ,sell='" + this.textBox4.Text + "'where id='" + this.textBox5.Text + "';";

            MySqlConnection lm = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, lm);
            MySqlDataReader myReader;


            try
            {
                lm.Open();
                myReader = cmdDataBase.ExecuteReader();
              //  MessageBox.Show("updated");
                while (myReader.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
          //  lm.close();



            string uery = "select id as'Product Id',name as 'Product Name',quantity,price as 'ORGINAL PRICE PP',sell as 'SELLING PRICE PP'  from product;";

            MySqlConnection conDataBas = new MySqlConnection(constring);
            MySqlCommand cmdDataBas = new MySqlCommand(uery, conDataBas);


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataBas;
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
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();





        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
                textBox5.Text = selectedRow.Cells[0].Value.ToString();
                textBox1.Text = selectedRow.Cells[1].Value.ToString();

                textBox3.Text = selectedRow.Cells[2].Value.ToString();
                textBox2.Text = selectedRow.Cells[3].Value.ToString();
                textBox4.Text = selectedRow.Cells[4].Value.ToString();









            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select id as'Product Id',name as 'Product Name',quantity,price as 'ORGINAL PRICE PP',sell as 'SELLING PRICE PP'  from product where name='" + this.textBox1.Text + "';";

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
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

        }

        private void Button6_Click(object sender, EventArgs e)
        {
           // double x = 10, y = -29, z;
         //   z = x + y;
         
           // MessageBox.Show(z.ToString());

            //Console.WriteLine("The Money you have now is {0}", z);

            this.Hide();
            MainForm1 mainform = new MainForm1();
            mainform.Show();
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

          
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            // Application.Exit();
            //this.close();
            this.Close();
            this.Hide();

            MainForm1 registerform = new MainForm1();
            registerform.Show();



        }

        private void Label8_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            MainForm1 registerform = new MainForm1();
            registerform.Show();

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Close the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                Application.Exit();
            }

        }
    }
    }
