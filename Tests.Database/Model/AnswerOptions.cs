namespace Tests.Database.Model
{
    public class AnswerOptions
    {
        public int IdAnswerOptions { get; set; }
        public int QuestionsId { get; set; }
        public Questions Question { get; set; }
        public string Possiblenswer { get; set; }
        public bool? CorrectAnswer { get; set; }
    }
}
