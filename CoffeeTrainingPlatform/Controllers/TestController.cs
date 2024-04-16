using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CoffeeTraining;

namespace CoffeeTrainingPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class TestController:Controller
    {
        readonly CoffeeTrainingPlatformDbContext _dbContext;

        public TestController(CoffeeTrainingPlatformDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [Route("getTest/{TestId}")]
        public IActionResult GetTest([FromRoute] int TestId)
        {
            var test = _dbContext.practiceTests.FirstOrDefault(test => test.Id == TestId);
            return Ok(test);
        }
        [Route("getQuestion/{TestId}")]
        public IActionResult GetQuesrion([FromRoute] int TestId)
        {
            var question = _dbContext.TestQuestions.Where(question => question.TestId == TestId);
            return Ok(question);
        }

        [Route("getAnswers/{QuestionId}")]
        public IActionResult GetAnswers([FromRoute] int QuestionId)
        {
            var answers = _dbContext.TestAnswers.Where(answer => answer.QuestionId == QuestionId);
            return Ok(answers);
        }

    }
}
