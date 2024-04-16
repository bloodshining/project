namespace CoffeeLearnWebApi.Models
{
    public class Progress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }
        public int ProgressPercent { get; set; }
        public DateTime DateDone { get; set; }
    }
}
