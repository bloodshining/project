using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CoffeeTraining;

namespace CoffeeTrainingPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class LectureController:Controller
    {
        private readonly CoffeeTrainingPlatformDbContext _dbContext;

        public LectureController(CoffeeTrainingPlatformDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("getLecture/{id}")]
        public IActionResult GetLecture([FromRoute] int id )
        {
            var lecture = _dbContext.Lecture.FirstOrDefault(lecture => lecture.Id == id);
            return Ok(lecture);
        }
   
    }
}
