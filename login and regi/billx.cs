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
    public partial class billx : Form
    {
        public billx()
        {
            InitializeComponent();
            On();
        }
        double f;
        void On()
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string que = "select sum(total) from temp;";


            MySqlConnection onDataBase = new MySqlConnection(constring);
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

                        f = double.Parse(SUM);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        // MessageBox.Show("ok");



                        onDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            string result = f.ToString();
            textBox12.Text = result.ToString();
        }
        private void Billx_Load(object sender, EventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            rr registerform = new rr();
            registerform.Show();

        }
        double p;
        private void Button11_Click(object sender, EventArgs e)
        {

        }
    }
}