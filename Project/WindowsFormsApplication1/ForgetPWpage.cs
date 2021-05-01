using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace WindowsFormsApplication1
{
    public partial class ForgetPWpage : Form
    {
        public ForgetPWpage()
        {
            InitializeComponent();
        }

        private void ForgetPWpage_Load(object sender, EventArgs e)
        {

        }

        private void CancelB_Click(object sender, EventArgs e)
        {
            LoginPage lgpage = new LoginPage();
            lgpage.Show();
            this.Hide();
        }

        private void SubmitB_Click(object sender, EventArgs e)
        {

           NewPWpage nwpwpage = new NewPWpage();
                    nwpwpage.Show();
                    this.Hide();

        }

        private void Emailbox_TextChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}
