using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;



namespace login_and_regi
{
    public partial class sell : Form
    {
        public sell()
        {
            InitializeComponent();
             sonu();
            Fun();
        }
        void Fun()
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
        void sonu()
        {

            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select * from product;";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReade;


            try
            {
                conDataBase.Open();
                myReade = cmdDataBase.ExecuteReader();
               // MessageBox.Show("updated");
                while (myReade.Read())
                {
                    string s = myReade.GetString("name");
                   // listBox1.Items.Add(s);
                    
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            conDataBase.Close();





        }

        private void Sell_Load(object sender, EventArgs e)
        {

        }
        public void exportgridtopdf(DataGridView dgw, string filename)
        {
            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            PdfPTable pdftable = new PdfPTable(dgw.Columns.Count);
            pdftable.DefaultCell.Padding = 3;
            pdftable.WidthPercentage = 100;
            pdftable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdftable.DefaultCell.BorderWidth = 1;
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);
            foreach (DataGridViewColumn column in dgw.Columns)
            {


                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, text));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                pdftable.AddCell(cell);
            }
            foreach (DataGridViewRow row in dgw.Rows)
            {


                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdftable.AddCell(new Phrase(cell.Value.ToString(), text));
                }
            }

            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";

            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                {

                    Document pdfdoc = new Document(PageSize.A4, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfdoc, stream);
                    pdfdoc.Open();
                    pdfdoc.Add(pdftable);
                    pdfdoc.Close();
                    stream.Close();

                }

            }

        }

        private void DataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
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

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox4.Text))
            {
                double x = double.Parse(textBox2.Text);
                double y = double.Parse(textBox4.Text);
                double z = x * y;
                string result = z.ToString();
                textBox6.Text = result.ToString();
            }

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            textBox1.Text = selectedRow.Cells[0].Value.ToString();
            textBox3.Text = selectedRow.Cells[1].Value.ToString();

            textBox2.Text = selectedRow.Cells[2].Value.ToString();
          //  textBox5.Text = selectedRow.Cells[3].Value.ToString();
            textBox4.Text = selectedRow.Cells[3].Value.ToString();
            double x = double.Parse(textBox2.Text);
            double y = double.Parse(textBox4.Text);
            double z = x * y;
            string result = z.ToString();
            textBox6.Text = result.ToString();





        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
           // string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";

            //MySqlConnection conDataBase = new MySqlConnection(constring);
            


            //string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";



            double x = double.Parse(textBox2.Text);
            double y = double.Parse(textBox4.Text);
            double z = x * y;
            string result = z.ToString();
            textBox6.Text = result.ToString();

        }
        
        private void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }
        double p, q, r,pp,ddd,eee;

        private void Button3_Click(object sender, EventArgs e)
        {

          // double p,q,r;
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string que = "select quantity from product where id='" + this.textBox1.Text + "';";


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



                       // MessageBox.Show("ok");



                        onDataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
             q = double.Parse(textBox2.Text);
            r = p - q;
            string result = r.ToString();



            // Console.WriteLine("Hello {0}", r);



            string qy = "update product set quantity=@textValue where id='" + this.textBox1.Text + "';";



            MySqlConnection cDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBse = new MySqlCommand(qy, cDataBase);
            cmdDataBse.Parameters.AddWithValue("@textValue", result);

            MySqlDataReader myReade;


            try
            {
                cDataBase.Open();
                myReade = cmdDataBse.ExecuteReader();
                //MessageBox.Show("updated");
                while (myReade.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            cDataBase.Close();




            //for lol table
          //  double pp;

            string quz = "select price from product where id='" + this.textBox1.Text + "';";


            MySqlConnection onDaBase = new MySqlConnection(constring);
            MySqlCommand cmdDa = new MySqlCommand(quz, onDaBase);
            MySqlDataReader Readx;
            string St;

            try
            {
                onDaBase.Open();
                Readx = cmdDa.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Readx.HasRows)

                {
                    if (Readx.Read())
                    {
                        //string mystring;

                        St = Readx.GetString(0);

                      pp = double.Parse(St);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                      //  MessageBox.Show("ok");



                        onDaBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            double xt = double.Parse(textBox2.Text);
            double zz = xt * pp;
            //insert lol
            string x1 = "insert into lol(name,city,phn,pid,pname,qunatity,price,sell,datee) values('" + this.textBox9.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox2.Text + "',@textValue,'" + this.textBox6.Text + "',@DATE);";


            MySqlConnection x2 = new MySqlConnection(constring);
            MySqlCommand x3 = new MySqlCommand(x1, x2);
            x3.Parameters.AddWithValue("@textValue", zz);
            x3.Parameters.AddWithValue("@DATE", DateTime.Now);


            MySqlDataReader x4;


            try
            {
                x2.Open();
                x4 = x3.ExecuteReader();
                // MessageBox.Show("saved");
                while (x4.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




            x2.Close();













































            //for end lol table































            // string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string qu = "insert into temp(id,name,quantity,total) values('" + this.textBox1.Text + "','" + this.textBox3.Text + "','" + this.textBox2.Text + "','" + this.textBox6.Text + "');";


            MySqlConnection conDataBas = new MySqlConnection(constring);
            MySqlCommand cmdDataBas = new MySqlCommand(qu, conDataBas);
            MySqlDataReader myReader;


            try
            {
                conDataBas.Open();
                myReader = cmdDataBas.ExecuteReader();
               // MessageBox.Show("saved");
                while (myReader.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




            conDataBas.Close();
















































           // string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            
            string query = "select id as 'Product Id', name as'Product Name',quantity,total as 'PRICE'  from temp;";
          //  string qu= "insert into sell(name,sell) values('" + this.textBox3.Text + "','" + this.textBox2.Text + "');";

            MySqlConnection conDataBase = new MySqlConnection(constring);
           
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
          //  new MySqlCommand(qu, conDataBase);


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






           // string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string qury = "select id as'Product Id',name as 'Product Name',quantity,sell as 'SELLING PRICE PP'  from product where quantity>0;";


            MySqlConnection conDatBase = new MySqlConnection(constring);
            MySqlCommand cmd = new MySqlCommand(qury, conDatBase);




            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmd;
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

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();





        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView2.Rows[index];
            textBox5.Text = selectedRow.Cells[0].Value.ToString();
            textBox10.Text = selectedRow.Cells[1].Value.ToString();

            textBox11.Text = selectedRow.Cells[2].Value.ToString();
            //  textBox5.Text = selectedRow.Cells[3].Value.ToString();
          //  textBox4.Text = selectedRow.Cells[3].Value.ToString();

        }

        private void Label10_Click(object sender, EventArgs e)
        {

        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox10.Clear();
            textBox11.Clear();

        }

        double a, b, c,d,o,i,j,k,cc,dd;

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Label15_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Close the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                Application.Exit();
            }

        }

        private void Label18_Click(object sender, EventArgs e)
        {

        }

        private void Label14_Click(object sender, EventArgs e)
        {

        }

        private void Label13_Click(object sender, EventArgs e)
        {

        }

        private void Label23_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }

        private void Label28_Click(object sender, EventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            rr registerform = new rr();
            registerform.Show();

        }

        private void TextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void Label25_Click(object sender, EventArgs e)
        {

        }

        private void Label33_Click(object sender, EventArgs e)
        {

        }

        private void Label28_Click_1(object sender, EventArgs e)
        {

        }

        private void Button15_Click(object sender, EventArgs e)
        {
            //this.Hide();
            billx mainform = new billx();
            mainform.Show();
        }

        double f;

        private void Button12_Click(object sender, EventArgs e)
        {
            textBox15.Clear();

            textBox14.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox6.Clear();
            textBox1.Clear();
            textBox2.Clear();

            textBox3.Clear();

            textBox4.Clear();

            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox5.Clear();
            textBox10.Clear();
            textBox11.Clear();
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "delete from temp;";


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
        void tuu()
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";

            string query = "select id as 'Product Id', name as'Product Name',quantity,total as 'PRICE'  from temp;";
            //  string qu= "insert into sell(name,sell) values('" + this.textBox3.Text + "','" + this.textBox2.Text + "');";

            MySqlConnection conDataBase = new MySqlConnection(constring);

            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            //  new MySqlCommand(qu, conDataBase);


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

        private void Button10_Click(object sender, EventArgs e)
        {


            DialogResult dialog = MessageBox.Show("Do You Really Want to finilize the bill?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
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

                //insert



                string query = "insert into temp(quantity,total) values('Total','" + this.textBox12.Text + "');";

                MySqlConnection conDataBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                MySqlDataReader myReader;


                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBase.ExecuteReader();
                    //  MessageBox.Show("saved");
                    while (myReader.Read())
                    {

                    }



                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

                //function for load
                tuu();


                //bill
                exportgridtopdf(dataGridView2, "test");


                //reset
                string quer = "delete from temp;";


                MySqlConnection conDaaBase = new MySqlConnection(constring);
                MySqlCommand cmdDataBaseu = new MySqlCommand(quer, conDaaBase);













                try
                {
                    MySqlDataAdapter sda = new MySqlDataAdapter();
                    sda.SelectCommand = cmdDataBaseu;
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


        }

        private void Button11_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox12.Text);
            double y = double.Parse(textBox13.Text);
            double z = y- x;
            string result = z.ToString();
            textBox14.Text = result.ToString();


            if (z < 0)
            {
                z = Math.Abs(z);
                string resul = z.ToString();


                //MessageBox.Show("due is", z.ToString());
                MessageBox.Show("The due is :" + " " + resul + " ");

                if (textBox15.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Enter Your ID", "Empty Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string constrin = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";

                    string que = "select due from due where id='" + this.textBox15.Text + "';";


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

                                p = double.Parse(SUM);
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



                   double e1;
                    e1 = z + p;
                    string res = e1.ToString();

                    string queee = "update due set due=@textValue      where id='" + this.textBox15.Text + "';";

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
                    string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
                    string query = "insert into tot(name,city,pnum,total,datee) values('" + this.textBox9.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox12.Text + "',@DATE);";

                    MySqlConnection conDataBase = new MySqlConnection(constring);
                    MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
                    cmdDataBase.Parameters.AddWithValue("@DATE", DateTime.Now);
                   // DATE = DATE.Dumb();

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


                }

            }




             else

            {
                string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
                string query = "insert into tot(name,city,pnum,total,datee) values('" + this.textBox9.Text + "','" + this.textBox7.Text + "','" + this.textBox8.Text + "','" + this.textBox12.Text + "',@DATE);";

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


            }
            





        }

        private void TextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            MainForm1 registerform = new MainForm1();
            registerform.Show();

        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm1 mainform = new MainForm1();
            mainform.Show();
        }

        double n, s,xxx;
        private void UPDATE_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string que = "select quantity from product where id='" + this.textBox5.Text + "';";


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

                        a=double.Parse(SUM);
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



































            string em= "select quantity from temp where id='" + this.textBox5.Text + "';";


            MySqlConnection DataBase = new MySqlConnection(constring);
            MySqlCommand mdDatBase = new MySqlCommand(em, DataBase);
            MySqlDataReader meader;
            string SU;

            try
            {
                DataBase.Open();
                meader = mdDatBase.ExecuteReader();
                //  MessageBox.Show("ok");
                if (meader.HasRows)

                {
                    if (meader.Read())
                    {
                        //string mystring;

                        SU = meader.GetString(0);

                        d= double.Parse(SU);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        //MessageBox.Show("ok");



                        DataBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


          
            string dd = "select sell from product where id='" + this.textBox5.Text + "';";


            MySqlConnection onData = new MySqlConnection(constring);
            MySqlCommand zq = new MySqlCommand(dd, onData);
            MySqlDataReader Reaer;
            string Mc;

            try
            {
                onData.Open();
                Reaer = zq.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Reaer.HasRows)

                {
                    if (Reaer.Read())
                    {
                        //string mystring;

                        Mc= Reaer.GetString(0);

                        n= double.Parse(Mc);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                        //MessageBox.Show("ok");



                        onData.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }






            //price

            string quz = "select price from product where id='" + this.textBox5.Text + "';";


            MySqlConnection onDaBase = new MySqlConnection(constring);
            MySqlCommand cmdDa = new MySqlCommand(quz, onDaBase);
            MySqlDataReader Readx;
            string St;

            try
             {
                onDaBase.Open();
                Readx = cmdDa.ExecuteReader();
                //  MessageBox.Show("ok");
                if (Readx.HasRows)

                {
                    if (Readx.Read())
                    {
                        //string mystring;

                        St = Readx.GetString(0);

                        xxx = double.Parse(St);
                        // x = (double)SUM;
                        //Console.WriteLine("Hello {0}", p);



                      //  MessageBox.Show("ok");



                        onDaBase.Close();

                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //price










            o = double.Parse(textBox11.Text);
            i = d - o;
            j = i + a;
            s = n * o;
            double ty = s;
            double tz = xxx * o;


        //    MessageBox.Show(tz.ToString());



            string r1 = ty.ToString();
            string r2 = tz.ToString();



            //lol
            string q1 = "update lol set price=@textValue1,sell=@textValue,qunatity='" + this.textBox11.Text + "' where pid='" + this.textBox5.Text + "';";



            MySqlConnection ataBase = new MySqlConnection(constring);
            MySqlCommand cmdtt = new MySqlCommand(q1, ataBase);
            cmdtt.Parameters.AddWithValue("@textValue", r1);
            cmdtt.Parameters.AddWithValue("@textValue1", r2);

            //  cmdDataBse.Parameters.AddWithValue("@textValue1", l);


            MySqlDataReader myx;


            try
            {
                ataBase.Open();
                myx = cmdtt.ExecuteReader();
                //MessageBox.Show("updated");
                while (myx.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            ataBase.Close();




            //lol













            string resul = j.ToString();
            string l = s.ToString();

            string qy = "update product set quantity=@textValue where id='" + this.textBox5.Text + "';";



            MySqlConnection cDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBse = new MySqlCommand(qy, cDataBase);
            cmdDataBse.Parameters.AddWithValue("@textValue", resul);
          //  cmdDataBse.Parameters.AddWithValue("@textValue1", l);


            MySqlDataReader myReade;


            try
            {
                cDataBase.Open();
                myReade = cmdDataBse.ExecuteReader();
                //MessageBox.Show("updated");
                while (myReade.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            cDataBase.Close();
            string result = res.ToString();
           // cmdDataBse.Parameters.AddWithValue("@textValue1", l);

            string z = "update temp set quantity='" + this.textBox11.Text + "',total=@textValue1 where id='" + this.textBox5.Text + "';";



            MySqlConnection cDataBas = new MySqlConnection(constring);
            MySqlCommand cmdataBse = new MySqlCommand(z, cDataBas);
            //cmdDataBse.Parameters.AddWithValue("@textValue", result);
            cmdataBse.Parameters.AddWithValue("@textValue1", l);


            MySqlDataReader mReade;


            try
            {
                cDataBas.Open();
                mReade = cmdataBse.ExecuteReader();
               // MessageBox.Show("updated");
                while (mReade.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            cDataBas.Close();
            // update lol

           



            // done update lol


            string uery = "select id as 'Product Id', name as'Product Name',quantity,total as 'ORGINAL PRICE PP'  from temp;";
            //  string qu= "insert into sell(name,sell) values('" + this.textBox3.Text + "','" + this.textBox2.Text + "');";

            MySqlConnection conDataasec = new MySqlConnection(constring);

            MySqlCommand cmdDataase = new MySqlCommand(uery, conDataasec);
            //  new MySqlCommand(qu, conDataBase);


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDataase;
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
            conDataasec.Close();

            string u = "select id as'Product Id',name as 'Product Name',quantity,sell as 'SELLING PRICE PP'  from product where quantity>0;";


            MySqlConnection c = new MySqlConnection(constring);
            MySqlCommand cm = new MySqlCommand(u, c);




            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
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

           


           // cDatax.Close();



        }
        double t,m,res;
        private void Button7_Click(object sender, EventArgs e)
        {

           // double x = double.Parse(textBox11.Text);

            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string que = "select quantity from product where id='" + this.textBox5.Text + "';";


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

                        t = double.Parse(SUM);
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
             m = double.Parse(textBox11.Text);
            res = t+m;
            string result = res.ToString();
            string qy = "update product set quantity=@textValue where id='" + this.textBox5.Text + "';";



            MySqlConnection cDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBse = new MySqlCommand(qy, cDataBase);
            cmdDataBse.Parameters.AddWithValue("@textValue", result);

            MySqlDataReader myReade;


            try
            {
                cDataBase.Open();
                myReade = cmdDataBse.ExecuteReader();
               // MessageBox.Show("updated");
                while (myReade.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }



            cDataBase.Close();
            

          //  cDataBase.Close();



























            string query = "DELETE from temp  where id='" + this.textBox5.Text + "';";

            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBase = new MySqlCommand(query, conDataBase);
            MySqlDataReader myReader;


            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
               // MessageBox.Show("DELETETED");
                while (myReader.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            conDataBase.Close();
            // dlt from lol


            string qu = "DELETE from lol  where pid='" + this.textBox5.Text + "';";

            MySqlConnection conDaaBase = new MySqlConnection(constring);
            MySqlCommand cmdDaaBase = new MySqlCommand(qu, conDaaBase);
            MySqlDataReader mReader;


            try
            {
                conDaaBase.Open();
                mReader = cmdDaaBase.ExecuteReader();
             //   MessageBox.Show("DELETETED");
                while (mReader.Read())
                {

                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




            conDaaBase.Close();






            //dlt from lol



            string st = "select id as 'Product Id', name as'Product Name',quantity,total as 'ORGINAL PRICE PP'  from temp;";
            //  string qu= "insert into sell(name,sell) values('" + this.textBox3.Text + "','" + this.textBox2.Text + "');";

            MySqlConnection tt = new MySqlConnection(constring);

            MySqlCommand xx = new MySqlCommand(st, tt);
            //  new MySqlCommand(qu, conDataBase);


            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = xx;
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
            tt.Close();














            string u = "select id as'Product Id',name as 'Product Name',quantity,sell as 'SELLING PRICE PP'  from product where quantity>0;";


            MySqlConnection c = new MySqlConnection(constring);
            MySqlCommand cm = new MySqlCommand(u, c);




            try
            {
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cm;
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

        private void Button5_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "delete from temp;";


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
        string rr;
        private void Button6_Click(object sender, EventArgs e)
        {
            string constring = "datasource=127.0.0.1;port=3306;username=root;password=root;database=log";
            string query = "select id as'Product Id',name as 'Product Name',quantity,price as 'ORGINAL PRICE PP',sell as 'SELLING PRICE PP'  from product where name='" + this.textBox3.Text+ "' and quantity>0;";

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






            /* MySqlDataAdapter sda = new MySqlDataAdapter();
             sda.SelectCommand = cmdDataBase;
             DataTable dbdataset = new DataTable();
             sda.Fill(dbdataset);
             BindingSource bSource = new BindingSource();
             bSource.DataSource = dbdataset;
             dataGridView1.DataSource = bSource;
             sda.Update(dbdataset);*/



        }
    }
    }

