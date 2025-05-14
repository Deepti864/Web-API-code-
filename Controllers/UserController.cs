using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserDetails.Models;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using UserDetails.Data;

namespace UserDetails.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    { 
   private readonly AppDbContext _context;

    public UserController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_context.users.ToList());
    }

    [HttpPost]
    public IActionResult Post([FromBody] User user)
    {
        _context.users.Add(user);
        _context.SaveChanges();
        return CreatedAtAction(nameof(Get), new { id = user.ID }, user);
    }
}

}


