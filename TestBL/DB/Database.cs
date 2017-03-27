using System.Collections.Generic;

namespace TestBL.DB
{
    public class Database
    {
        public static List<Question> Questions = new List<Question>
        {
            new Question
            {
                Id = 1,
                Name = "They _______ when they were on holiday and they fell in love.",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Id = 1,
                        Name = "have met"
                    },
                    new Answer
                    {
                        Id = 2,
                        Name = "are meeting"//true
                    },
                    new Answer
                    {
                        Id = 3,
                        Name = "met"
                    },
                    new Answer
                    {
                        Id = 4,
                        Name = "were met"
                    }
                }
             },

             new Question
            {
                Id = 2,
                Name = "When ______ start work?",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Id = 1,
                        Name = "do you" // true
                    },
                    new Answer
                    {
                        Id = 2,
                        Name = "are you"
                    },
                    new Answer
                    {
                        Id = 3,
                        Name = "you do"
                    },
                    new Answer
                    {
                        Id = 4,
                        Name = "you are"
                    }
                }
             },

               new Question
            {
                Id = 3,
                Name = "She ______ and walked away.",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Id = 1,
                        Name = "smile" 
                    },
                    new Answer
                    {
                        Id = 2,
                        Name = "smiled" // true
                    },
                    new Answer
                    {
                        Id = 3,
                        Name = "smiles"
                    },
                    new Answer
                    {
                        Id = 4,
                        Name = "is smile"
                    }
                }
             },
                    new Question
            {
                Id = 4,
                Name = "I look forward to ______ from you.",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Id = 1,
                        Name = "hearing"
                    },
                    new Answer
                    {
                        Id = 2,
                        Name = "heard" 
                    },
                    new Answer
                    {
                        Id = 3,
                        Name = "hear"// true
                    },
                    new Answer
                    {
                        Id = 4,
                        Name = "was hear"
                    }
                }
             },

                           new Question
            {
                Id = 5,
                Name = "That ______ like a great idea.",
                Answers = new List<Answer>
                {
                    new Answer
                    {
                        Id = 1,
                        Name = "is"
                    },
                    new Answer
                    {
                        Id = 2,
                        Name = "seem"// true
                    },
                    new Answer
                    {
                        Id = 3,
                        Name = "sounds"
                    },
                    new Answer
                    {
                        Id = 4,
                        Name = "was"
                    }
                }
             }
        };
    }
}
