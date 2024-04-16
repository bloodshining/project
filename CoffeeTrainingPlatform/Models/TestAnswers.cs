namespace CoffeeTrainingPlatform.Models
{
    public class TestAnswers
    {   
        public int Id { get; set; }
        public int QuestionId {  get; set; }
        public string Answer { get; set; }
        public bool IsCorrect { get; set; }
    }
}
