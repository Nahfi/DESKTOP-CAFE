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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            chun();
        }
        void chun()
        {

            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select id as'Product Id',name as 'Product Name',quantity,sell as 'SELLING PRICE PP'  from product where quantity>0;";


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
        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
