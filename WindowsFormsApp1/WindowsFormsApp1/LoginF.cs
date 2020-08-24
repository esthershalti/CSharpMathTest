using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;


namespace WindowsFormsApp1
{
    public partial class LoginF : Form
    {
        string u = null;
        int p = 0;
        public LoginF()
        {
            InitializeComponent();
        }
        private void EnterButton_Click(object sender, EventArgs e)
        {
            u = userNameText.Text;
            p = Int32.Parse(PasswordText.Text);
            ClassBL bl = new ClassBL();
            bool find = bl.Exist(u, p);
            if (find)
            {
                string message = "✔️זוהיתם בהצלחה ";
                string title = "Message";
                MessageBox.Show(message, title);
                TEST t = new TEST(Convert.ToInt32(PasswordText.Text));
                t.Show();
            }
            else
                MessageBox.Show("הפרטים שגויים!");
            u = null;
            p = 0;
            userNameText.Text = "";
            PasswordText.Text = "";
        }
    }
}