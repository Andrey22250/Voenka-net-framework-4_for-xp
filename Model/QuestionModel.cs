namespace voenka.Model
{
    public class QuestionModel
    {
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public int AnswerIndex { get; set; }
    }
}