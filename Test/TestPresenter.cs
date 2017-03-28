using System;
using System.Drawing.Text;
using System.Linq;
using TestBL;
using TestBL.DB;

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
            _view.Question = Database.Questions.First();
        }
        
        public void _view_NextQuestionClick(object sender, EventArgs e)
        {
            var oldQuestion = ((ITestForm)sender).Question;
            var index = Database.Questions.IndexOf(oldQuestion);
            if (index == Database.Questions.Count - 1)
                return;
            _view.Question = Database.Questions.ElementAt(++index);

        }
    }
}
