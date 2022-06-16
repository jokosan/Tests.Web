using System.Collections.Generic;

namespace Tests.Database.Model
{
    public class Questions
    {
        public int IdQuestions { get; set; }
        public int? TestsId { get; set; }
        public ListTests ListTests { get; set; }
        public string QuestionText { get; set; }
        public ICollection<AnswerOptions> AnswerOptions { get; set; }
    }
}
