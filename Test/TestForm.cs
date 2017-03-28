using System;
using System.Windows.Forms;
using TestBL;

namespace Test
{
    public interface ITestForm
    {
        Question Question { get; set; }
        event EventHandler StartTestClick;
        event EventHandler NextQuestionClick;
        event EventHandler CompleteClick;
    }
    public partial class TestForm : Form, ITestForm
    {
        private Question _question;

        public Question Question
        {
            get { return _question; }
            set
            {
                var question = value;
                sentence.Text = question.Name;
                response_a.Text = question.Answers[0].Name;
                response_a.Text = question.Answers[1].Name;
                response_a.Text = question.Answers[2].Name;
                response_a.Text = question.Answers[3].Name;

            }
        }

        public TestForm()
        {
            InitializeComponent();
            //обработчик события, переходит на метод 
            pb_start.Click += Start_Click;
            pb_next.Click += Next_Click;
            pb_complete.Click += Complete_Click;
        }

        #region Проброс событий
        public void Start_Click(object sender, EventArgs e)
        {
            if (StartTestClick != null) StartTestClick(this, EventArgs.Empty);
        }

        public void Next_Click(object sender, EventArgs e)
        {
            NextQuestionClick?.Invoke(this, EventArgs.Empty);
        }

        public void Complete_Click(object sender, EventArgs e)
        {
            if (CompleteClick != null) CompleteClick(this, EventArgs.Empty);
        }

        #endregion
        #region Реализация интерфейса ITestForm
        public event EventHandler StartTestClick;
        public event EventHandler NextQuestionClick;
        public event EventHandler CompleteClick;
        #endregion
    }
}
