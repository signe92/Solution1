using Microsoft.AspNetCore.Mvc;
using GenbrugsmarkedAPI.Repositories;
using Core.Modeller;

namespace GenbrugsmarkedAPI.Controllers;
[ApiController]
[Route("api/User")]
public class UserController : ControllerBase
{
    IUserRepository userRepo;
    
    public UserController(IUserRepository userRepo)
    {
        this.userRepo = userRepo;
    }
    
    [HttpGet]
    public List<User> GetAll()
    {
        return userRepo.GetAll();
    }
    
    
}