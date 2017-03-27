using System.Collections.Generic;

namespace TestBL
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Answer> Answers { get; set; }
    }
}
