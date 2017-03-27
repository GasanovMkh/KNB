using System.Collections.Generic;

namespace TestBL.DB
{
   public class Database
    {
        public static List<Question>  Questions = new List<Question>
        {
            new Question
            {
                Id = 1,
                Name = "Как объячить переменную?",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Id = 1,
                        Name = "Сделать то"
                    }
                }
            }
        };
    }
}
