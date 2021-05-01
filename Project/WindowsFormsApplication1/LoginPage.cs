using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class LoginPage : Form
    {
        
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void UserName_Click(object sender, EventArgs e)
        {

        }

        private void PWbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SignUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SingUp sgnpage = new SingUp();
            sgnpage.Show();
            this.Hide();
        }

        private void ForgotPWLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPWpage fgpage = new ForgetPWpage();
            fgpage.Show();
            this.Hide();
        }

        private void LoginB_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-I2JB8K5;Initial Catalog=Login;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login_tb where User_Name='" + UNbox.Text +"' and Password= '"+ PWbox.Text +"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()== "1")
            {
                Homepage hmpage = new Homepage();
                hmpage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Check your UserName and Password!","aleart",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


            
        }

        private void ExitB_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

      

        
       

       
    }
}
