using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace CoffeeTrainingPlatform.Models
{
    public class ProgressUploadModel
    {
        public int Percent { get; set; }
        public int UserId { get; set; }
        public int TestId { get; set; }

    }
}
