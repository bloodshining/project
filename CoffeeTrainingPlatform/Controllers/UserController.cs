using CoffeeTraining;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeTrainingPlatform.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class UserController : Controller
    {
        readonly CoffeeTrainingPlatformDbContext _dbContext;

        public UserController(CoffeeTrainingPlatformDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        [Route("getUser/{login}")]
        public IActionResult GetUser([FromRoute]string login)
        {
            var user = _dbContext.Users.FirstOrDefault(user => user.Login == login);
            return Ok(user);
        }
    }
}
