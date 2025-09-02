using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using studentlecture.Data;
using studentlecture.Models;

namespace studentlecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuddentController (SchoolDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetStudents()
        {
            return await context.Students.ToListAsync();
        }
    }
}
