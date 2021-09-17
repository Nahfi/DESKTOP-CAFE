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
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Labelclose_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD loginform = new ADD();
            loginform.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sell loginform = new sell();
            loginform.Show();
           

        }

        private void Button3_Click(object sender, EventArgs e)
        {
             this.Hide();
             transaction loginform = new transaction();
             loginform.Show();

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            loss loginform = new loss();
            loginform.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do You Really Want to Close the Application?", "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)

            {
                Application.Exit();
            }

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();

            login_from registerform = new login_from();
            registerform.Show();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            due loginform = new due();
            loginform.Show();

        }

        private void MainForm1_Load(object sender, EventArgs e)
        {

        }

        private void Label16_Click(object sender, EventArgs e)
        {

        }

        private void Button7_Click(object sender, EventArgs e)
        {
            
        }
    }
}
