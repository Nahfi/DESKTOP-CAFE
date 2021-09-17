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
    public partial class loss : Form
    {
        public loss()
        {
            InitializeComponent();



            alexx();
            // tui();        
        }
        void alexx()
        {


            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string que = "select sum(sell) from lol;";


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

                        s1 = double.Parse(SUM);
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

            string qu = "select sum(price) from lol;";


            MySqlConnection DataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatBas = new MySqlCommand(qu, DataBase);
            MySqlDataReader Reade;
            string SU;

            try
            {
                DataBase.Open();
                Reade = cmdDatBas.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Reade.HasRows)

                {
                    if (Reade.Read())
                    {
                        //string mystring;

                        SU = Reade.GetString(0);

                        s2 = double.Parse(SU);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        // MessageBox.Show("ok");



                        DataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            string qkz = "select sum(due) from due;";


            MySqlConnection DataBasexz = new MySqlConnection(constring);
            MySqlCommand cmdDatBasxz = new MySqlCommand(qkz, DataBasexz);
            MySqlDataReader Readexz;
            string SUxz;

            try
            {
                DataBasexz.Open();
                Readexz = cmdDatBasxz.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Readexz.HasRows)

                {
                    if (Readexz.Read())
                    {
                        //string mystring;

                        SUxz = Readexz.GetString(0);

                        e1 = double.Parse(SUxz);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        // MessageBox.Show("ok");



                        DataBasexz.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
















            s3 = s1 - s2;
            string result = s1.ToString();
            textBox1.Text = result.ToString();
            string resul = s2.ToString();
            textBox4.Text = e1.ToString();

            textBox2.Text = resul.ToString();

            string esult = s3.ToString();
            textBox3.Text = esult.ToString();
            double x1 = s1 - e1;
            textBox5.Text = x1.ToString();




        }








        /* void tui()
         {

             string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
             string que = "select sum(sell) from lol;";


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

                       double  s1 = double.Parse(SUM);
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

             string qu = "select sum(price) from lol;";


             MySqlConnection DataBase = new MySqlConnection(constring);
             MySqlCommand cmdDatBas = new MySqlCommand(qu, DataBase);
             MySqlDataReader Reade;
             string SU;

             try
             {
                 DataBase.Open();
                 Reade = cmdDatBas.ExecuteReader();
                 //  MessageBox.Show("ok");
                 if (Reade.HasRows)

                 {
                     if (Reade.Read())
                     {
                         //string mystring;

                         SU = Reade.GetString(0);

                        double s2 = double.Parse(SU);
                         // x = (double)SUM;
                         //Console.WriteLine("Hello {0}", p);



                         // MessageBox.Show("ok");



                         DataBase.Close();

                     }
                 }



             }
             catch (Exception ex)
             {

                 MessageBox.Show(ex.Message);
             }
            double s3 = s1 - s2;
             string result = s1.ToString();
             textBox1.Text = result.ToString();
             string resul = s2.ToString();
             textBox2.Text = resul.ToString();
             string esult = s3.ToString();
             textBox3.Text = esult.ToString();



         }
     }*/

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        double s1, s2, s3,s5;

        private void Label2_Click_1(object sender, EventArgs e)
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

        private void Label7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Close the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                Application.Exit();
            }

        }

        private void Loss_Load(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }
        double e1;

        private void Button1_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string que = "select sum(sell) from lol;";


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

                        s1= double.Parse(SUM);
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

            string qu = "select sum(price) from lol;";


            MySqlConnection DataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatBas = new MySqlCommand(qu, DataBase);
            MySqlDataReader Reade;
            string SU;

            try
            {
                DataBase.Open();
                Reade = cmdDatBas.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Reade.HasRows)

                {
                    if (Reade.Read())
                    {
                        //string mystring;

                        SU = Reade.GetString(0);

                        s2 = double.Parse(SU);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        // MessageBox.Show("ok");



                        DataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            string qkz = "select sum(due) from due;";


            MySqlConnection DataBasexz = new MySqlConnection(constring);
            MySqlCommand cmdDatBasxz = new MySqlCommand(qkz, DataBasexz);
            MySqlDataReader Readexz;
            string SUxz;

            try
            {
                DataBasexz.Open();
                Readexz = cmdDatBasxz.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Readexz.HasRows)

                {
                    if (Readexz.Read())
                    {
                        //string mystring;

                        SUxz = Readexz.GetString(0);

                        e1 = double.Parse(SUxz);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        // MessageBox.Show("ok");



                        DataBasexz.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
















            s3 = s1 - s2;
            string result = s1.ToString();
            textBox1.Text = result.ToString();
            string resul = s2.ToString();
            textBox4.Text = e1.ToString();

            textBox2.Text = resul.ToString();

            string esult = s3.ToString();
            textBox3.Text = esult.ToString();
            double x1 = s1 - e1;
            textBox5.Text = x1.ToString();





        }
    }
}
