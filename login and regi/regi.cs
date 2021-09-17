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
    public partial class regi : Form
    {
        public regi()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `regi`(`fname`, `lname`, `uname`, `pass`,`email`) VALUES (@fn, @ln, @usn, @pass,@email)", db.getConnection());

            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = textBox3.Text;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox2.Text;
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = textBox4.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = textBox5.Text;
            db.openConnection();

            // check if the textboxes contains the default values 
            if (!checkTextBoxesValues())
            {
                // check if the password equal the confirm password
                if (textBox5.Text.Equals(textBox6.Text))
                {
                    // check if this username already exists
                    if (checkUsername())
                    {
                        MessageBox.Show("This Username Already Exists, Select A Different One", "Duplicate Username", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // execute the query
                        if (command.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Your Account Has Been Created", "Account Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ERROR");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Wrong Confirmation Password", "Password Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Enter Your Informations First", "Empty Data", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }



            // close the connection
            db.closeConnection();


        }
        public Boolean checkUsername()
        {
            DB db = new DB();

            String username = textBox4.Text;

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `regi` WHERE `uname` = @usn", db.getConnection());

            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username;

            adapter.SelectCommand = command;

            adapter.Fill(table);

            // check if this username already exists in the database
            if (table.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public Boolean checkTextBoxesValues()
        {
            String fname = textBox1.Text;
            String lname = textBox3.Text;
            String email = textBox2.Text;
            String uname = textBox4.Text;
            String pass = textBox5.Text;

            if (fname.Equals("first name") || lname.Equals("last name") ||
                email.Equals("email address") || uname.Equals("username")
                || pass.Equals("password"))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        private void Labelclose_Click(object sender, EventArgs e)
        {

            //this.Close();
            //Application.Exit();
            this.Hide();
            login_from loginform = new login_from();
            loginform.Show();


        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RegisterForm_Load(object sender, EventArgs e)
        {
            // remove the focus from the textboxes by making a label the active control
            this.ActiveControl = label1;
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("first name"))
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            String fname = textBox1.Text;
            if (fname.ToLower().Trim().Equals("first name") || fname.Trim().Equals(""))
            {
                textBox1.Text = "first name";
                textBox1.ForeColor = Color.Gray;
            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            String lname = textBox3.Text;
            if (lname.ToLower().Trim().Equals("last name"))
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            String lname = textBox3.Text;
            if (lname.ToLower().Trim().Equals("last  name") || lname.Trim().Equals(""))
            {
                textBox3.Text = "last name";
                textBox3 .ForeColor = Color.Gray;
            }
        }

        
        private void TextBox2_Enter_1(object sender, EventArgs e)
        {
            String l = textBox2.Text;
            if (l.ToLower().Trim().Equals("email adress"))
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }

        }

        private void TextBox2_Leave_1(object sender, EventArgs e)
        {

            String l = textBox2.Text;
            if (l.ToLower().Trim().Equals("email adress") || l.Trim().Equals(""))
            {
                textBox2.Text = "email adress";
                textBox2.ForeColor = Color.Gray;
            }
        }

        private void TextBox4_Enter(object sender, EventArgs e)
        {
            String username = textBox4.Text;
            if (username.ToLower().Trim().Equals("username"))
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            String username = textBox4.Text;
            if (username.ToLower().Trim().Equals("username") || username.Trim().Equals(""))
            {
                textBox4.Text = "username";
                textBox4.ForeColor = Color.Gray;
            }

        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox5_Enter(object sender, EventArgs e)
        {
            String password = textBox5.Text;
            if (password.ToLower().Trim().Equals("password"))
            {
                textBox5.Text = "";
                textBox5.UseSystemPasswordChar = true;
                textBox5.ForeColor = Color.Black;
            }
        }

        private void TextBox5_Leave(object sender, EventArgs e)
        {
            String password = textBox5.Text;
            if (password.ToLower().Trim().Equals("password") || password.Trim().Equals(""))
            {
                textBox5.Text = "password";
                textBox5.UseSystemPasswordChar = false;
                textBox5.ForeColor = Color.Gray;
            }
        }

        private void TextBox6_Enter(object sender, EventArgs e)
        {
            String cpassword = textBox6.Text;
            if (cpassword.ToLower().Trim().Equals("confirm password"))
            {
                textBox6.Text = "";
                textBox6.UseSystemPasswordChar = true;
                textBox6.ForeColor = Color.Black;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_from loginform = new login_from();
            loginform.Show();
        }

        private void TextBox6_Leave(object sender, EventArgs e)
        {
            String password = textBox6.Text;
            if (password.ToLower().Trim().Equals("confirm password") || password.Trim().Equals(""))
            {
                textBox6.Text = "confirm password";
                textBox6.UseSystemPasswordChar = false;
                textBox6.ForeColor = Color.Gray;
            }

        }
    }
}



