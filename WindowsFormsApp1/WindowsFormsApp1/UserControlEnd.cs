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
    public partial class UserControlEnd : UserControl
    {
        private static UserControlEnd _ucEnd;
        public static UserControlEnd ucEnd
        {
            get
            {
                if (_ucEnd == null)
                    _ucEnd = new UserControlEnd();
                return _ucEnd;
            }
            set
            {
                _ucEnd = null;
            }
        }
        public UserControlEnd()
        {
            InitializeComponent();
        }
        Questions q = new Questions();
        ClassBL bl = new ClassBL();
        List<Answers> answers = new List<Answers>();
        public int getAnswer()
        {
            if (answers[0].ID == q.QuestionAnswer && radioButton1.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[1].ID == q.QuestionAnswer && radioButton2.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[2].ID == q.QuestionAnswer && radioButton3.Checked)
                return Convert.ToInt32(q.Percent);
            else if (answers[3].ID == q.QuestionAnswer && radioButton4.Checked)
                return Convert.ToInt32(q.Percent);
            return 0;
        }

        private void UserControlEnd_Load(object sender, EventArgs e)
        {
            q = bl.exerciseReturnRB();
            lblQuestion.Text = q.QuestionText;
            mark.Text = q.Percent.ToString();

            answers = bl.answerA(q.ID);
            radioButton1.Text = answers[0].AnswerValue.ToString();
            radioButton2.Text = answers[1].AnswerValue.ToString();
            radioButton3.Text = answers[2].AnswerValue.ToString();
            radioButton4.Text = answers[3].AnswerValue.ToString();
        }
    }
}      
