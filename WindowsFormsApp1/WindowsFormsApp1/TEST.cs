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
    public partial class TEST : Form
    {

        int mark = 0;
        int cnt = 1;
        int UserPassword;
        ClassBL bl = new ClassBL();
        public TEST(int userPassword)
        {
            InitializeComponent();
            UserPassword = userPassword;

        }

        private void TEST_Load(object sender, EventArgs e)
        {
            if (!panel1.Controls.Contains(UserControlTop.ucTop))
            {
                panel1.Controls.Add(UserControlTop.ucTop);
                UserControlTop.ucTop.BringToFront();
            }
            else
            {
                UserControlTop.ucTop.BringToFront();
            }
            cnt++;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (cnt < 11)
            {
                if (UserControlTop.ucTop.getAnswer() > -1)
                {
                    mark += UserControlTop.ucTop.getAnswer();
                    lblmark.Text = mark.ToString();
                }
            }
            else
            {
                if (UserControlEnd.ucEnd.getAnswer() > -1)
                {
                    mark += UserControlEnd.ucEnd.getAnswer();
                    lblmark.Text = mark.ToString();
                }
            }
            if (cnt <= 9)
            {
                UserControlTop.ucTop = null;
                if (!panel1.Controls.Contains(UserControlTop.ucTop))
                {
                    panel1.Controls.Add(UserControlTop.ucTop);
                    UserControlTop.ucTop.BringToFront();
                }
                else
                {
                    UserControlTop.ucTop.BringToFront();
                }
            }
            else if (cnt <= 15)
            {
                panel1.Controls.Clear();
                UserControlEnd.ucEnd = null;
                if (!panel1.Controls.Contains(UserControlEnd.ucEnd))
                {
                    panel1.Controls.Add(UserControlEnd.ucEnd);
                    UserControlEnd.ucEnd.BringToFront();
                }
                else
                {
                    UserControlEnd.ucEnd.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("endddd");
                bl.save(UserPassword, mark);
            }
            cnt++;
        }
    }
}
