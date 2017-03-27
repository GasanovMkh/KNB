using System.Collections.Generic;

namespace TestBL.DB
{
    public class QuestionsStore
    {
        public static Dictionary<Question, List<string>> Questions = new Dictionary<Question, List<string>>
        {
            {new Question {Id = 1,Name = "How to?"},
                new List<string>() {"ответ1","ответ2"} },

             {new Question {Id = 2,Name = "How to2?"},
                new List<string>() {"ответ1","ответ2"} }
        };
    }
}
