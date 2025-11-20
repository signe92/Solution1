using Microsoft.AspNetCore.Mvc;
using GenbrugsmarkedAPI.Repositories;
using Core.Modeller;

namespace GenbrugsmarkedAPI.Controllers;

[ApiController]
[Route("api/User")]
public class UserController : ControllerBase
{
    private readonly IUserRepository userRepo;

    public UserController(IUserRepository userRepo)
    {
        this.userRepo = userRepo;
    }

    [HttpGet]
    public ActionResult<List<User>> GetAll()
    {
        return userRepo.GetAll();
    }

    [HttpGet("{id:int}")]
    public ActionResult<User> GetById(int id)
    {
        var user = userRepo.GetUserById(id);
        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserLogin login)
    {

        var user = await userRepo.Login(login.Email, login.Password);

        if (user == null || user.Password != login.Password)
        {
            return Unauthorized();
        }

        return Ok(user.UserID);
    }
}