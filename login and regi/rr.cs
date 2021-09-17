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
    public partial class rr : Form
    {
        public rr()
        {
            InitializeComponent();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            sell registerform = new sell();
            registerform.Show();

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Rr_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label20_Click(object sender, EventArgs e)
        {

        }
        double p;
        private void Button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals("") || textBox2.Text.Trim().Equals("") || textBox3.Text.Trim().Equals("") || textBox4.Text.Trim().Equals("") || textBox5.Text.Trim().Equals(""))
            {
                MessageBox.Show("Enter Your all Information", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else


            {
                string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
                string query = "insert into rr(name,mail,pn,city,adress,datee) values('" + this.textBox2.Text + "','" + this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox4.Text + "','" + this.textBox5.Text + "',@DATE);";

                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                cmdDataBase.Parameters.AddWithValue("@DATE", DateTime.Now);

                MySqlDataReader myReader;


                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                   // MessageBox.Show("saved");
                    while (myReader.Read())
                    {

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                conDataBase.Close();
                string que = "select id from rr where pn='" + this.textBox3.Text + "';";


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

                            p = double.Parse(SUM);
                            // x = (double)SUM;
                            //Console.WriteLine("Hello {0}", p);



                            //  MessageBox.Show("ok");



                            onDataBase.Close();

                        }
                    }
                    MessageBox.Show("YOUR ID is :" + " " + p.ToString() + " ");




                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }




                string result = p.ToString();



                // Console.WriteLine("Hello {0}", r);



                //  string qy = "update product set quantity=@textValue where id='" + this.textBox1.Text + "';";
                string qy = "insert into due(id,name) values(@textValue,'" + this.textBox2.Text + "');";



                MySqlConnection cDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBse = new MySqlCommand(qy, cDataBase);
                cmdDataBse.Parameters.AddWithValue("@textValue", result);

                MySqlDataReader myReade;


                try
                {
                    cDataBase.Open();
                    myReade = cmdDataBse.ExecuteReader();
                 //   MessageBox.Show("updated");
                    while (myReade.Read())
                    {

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }



                cDataBase.Close();


            }









           // textBox15.Clear();

           // textBox14.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox1.Clear();
            textBox2.Clear();












        }
    }
}
