using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestBL;
using System.Windows.Forms;

namespace Test
{
    public class TestPresenter
    {
        private readonly ITestForm _view;
        private readonly ITestManager _manager;
        private readonly IMessageService _messageService;

        public TestPresenter(ITestForm view, ITestManager manager, IMessageService messageService)
        {
            _view = view;
            _manager = manager;
            _messageService = messageService;

            _view.StartTestClick += _view_StartTestClick;
            _view.NextQuestionClick += _view_NextQuestionClick;
        }

        public void _view_StartTestClick(object sender, EventArgs e)
        {
            _view.Question = "What ____ the time?";
            _view.Answer_A = "be";
            _view.Answer_B = "is";//
            _view.Answer_C = "are";
            _view.Answer_D = "was";
        }

        public void _view_NextQuestionClick(object sender, EventArgs e)
        {
        
        }
    }
}
