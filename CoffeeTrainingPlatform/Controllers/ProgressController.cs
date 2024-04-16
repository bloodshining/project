using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CoffeeTraining;
using CoffeeTrainingPlatform.Models;
using Microsoft.AspNetCore.SignalR;
using CoffeeTraining.Models;
using Microsoft.EntityFrameworkCore;

namespace CoffeeTrainingPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class ProgressController : Controller
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
                var existingProgress = await _dbContext.Progress
           .FirstOrDefaultAsync(p => p.UserId == model.UserId && p.TestId == model.TestId);

                if (existingProgress != null)
                {
                    // Если запись существует, удаляем её
                    _dbContext.Progress.Remove(existingProgress);
                }
                var progress = new Progress
                {
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
        [HttpGet]
        [Route("getProgress/{id}")]
        public async Task<IActionResult> GetProgress([FromRoute] int id)
        {
            var progress = _dbContext.Progress.Where(progress => progress.UserId == id);
            return Ok(progress);
        }
    }
}
