using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace WindowsFormsApp1
{
    public partial class UserControlTop : UserControl
    {

        private static UserControlTop _ucTop;
        public static UserControlTop ucTop
        {
            get
            {
                if (_ucTop == null)
                    _ucTop = new UserControlTop();
                return _ucTop;
            }
            set
            {
                _ucTop = null;
            }
        }
        public static int cnt = 1;
        Questions q = new Questions();
        public UserControlTop()
        {
            InitializeComponent();
        }
        ClassBL bl = new ClassBL();
        private void UserControlTop_Load(object sender, EventArgs e)
        {
            if (cnt <= 5)
            {
                q = bl.exerciseReturn6();
                lblQuestion.Text = q.QuestionText;
            }
            else
            {
                q = bl.exerciseReturn10();
                lblQuestion.Text = q.QuestionText;
            }
            mark.Text = q.Percent.ToString();
            cnt++;
        }
        public int getAnswer()
        {
            if (q.QuestionAnswer == Convert.ToInt32(txtAnswer.Text))
                return Convert.ToInt32(q.Percent);
            return 0;
        }
    }
}