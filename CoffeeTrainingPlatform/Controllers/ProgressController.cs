using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CoffeeTraining;
using CoffeeTrainingPlatform.Models;
using Microsoft.AspNetCore.SignalR;
using CoffeeTraining.Models;

namespace CoffeeTrainingPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProgressController:Controller
    {
        readonly CoffeeTrainingPlatformDbContext _dbContext;

        public ProgressController(CoffeeTrainingPlatformDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        
        [Route("upload")]
        [HttpPost]
        public async Task<IActionResult> UploadProgress([FromForm] ProgressUploadModel model) 
        {
            try
            {
                var progress = new Progress
                {
                    Id = 1,
                    UserId = model.UserId,
                    TestId = model.TestId,
                    ProgressPercent = model.Percent,
                    DateDone = DateTime.UtcNow,
                };
                _dbContext.Progress.Add(progress);
                await _dbContext.SaveChangesAsync();
                return Ok(progress);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
                return StatusCode(500, "Произошла ошибка при обработке запроса.");
            }

        }
    }
}
