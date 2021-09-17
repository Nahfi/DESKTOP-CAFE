using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login_and_regi
{
    public partial class valid : Form
    {
        public valid()
        {
            InitializeComponent();
        }

        private void Valid_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Text_TextChanged(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {
            String fname = text.Text;
            if(fname.Equals("12345"))
            {


                this.Hide();

                regi registerform = new regi();
                registerform.Show();

            }
            else
            {
                MessageBox.Show("Wrong  Password", "Wrong Data", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Close the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                Application.Exit();
            }

        }

        private void Label12_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();

            login_from registerform = new login_from();
            registerform.Show();
        }
    }
}
