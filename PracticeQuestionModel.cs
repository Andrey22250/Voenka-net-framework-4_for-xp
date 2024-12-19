using System.Collections.Generic;

namespace voenka.Model
{
    public class PracticeQuestionModel
    {
        public string StepName { get; set; }
        public string Question { get; set; }
        public List<string> Options { get; set; }
        public int AnswerIndex { get; set; }
        public string Description { get; set; }
        public string MainImagePath { get; set; }
        public string ActionImagePath { get; set; }
    }
}
