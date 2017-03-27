using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public interface ITestForm
    {
        string Question { get; set; }
        string Answer_A { get; set; }
        string Answer_B { get; set; }
        string Answer_C { get; set; }
        string Answer_D { get; set; }
        event EventHandler StartTestClick;
        event EventHandler NextQuestionClick;
        event EventHandler CompleteClick;
    }
    public partial class TestForm : Form, ITestForm
    {
        public string Question
        {
            get { return sentence.Text; }
            set { sentence.Text = value; }
        }
        public string Answer_A
        {
            get { return response_a.Text; }
            set { response_a.Text = value; }
        }
        public string Answer_B
        {
            get { return response_b.Text; }
            set { response_b.Text = value; }
        }
        public string Answer_C
        {
            get { return response_c.Text; }
            set { response_c.Text = value; }
        }
        public string Answer_D
        {
            get { return response_d.Text; }
            set { response_d.Text = value; }
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
