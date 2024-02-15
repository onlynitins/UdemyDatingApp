using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]     //https://localhost:5001/api/Users
public class UsersController : ControllerBase
{
    private readonly DataContext _context;

    public UsersController(DataContext context)
    {
        _context = context;
    }

    /* [HttpGet]
    public ActionResult<IEnumerable<AppUser>> getUsersInSync() //https://localhost:5001/api/Users/2
    {
        var users = _context.Users.ToList();
        return users;
    }

   
    [HttpGet("{id}")]
    public async Task<ActionResult<AppUser>>getUsersInSync(int id)
    {
        var user = await _context.Users.FindAsync(id);
        return user;
    }
    */

    [HttpGet]
    public async Task<ActionResult<IEnumerable<AppUser>>> getUsers() //https://localhost:5001/api/Users/2
    {
        var users = await _context.Users.ToListAsync();
        return users;
    }



    [HttpGet("{id}")]
    public ActionResult<AppUser> getUsersSync(int id)
    {
        var user = _context.Users.Find(id);
        return user;
    }

}
