using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Api.Model;
using StudentManagement.Api.Persistence;
using System.Net;

namespace StudentManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentDbContext _dbContext;
        public StudentController(StudentDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("students")]
        public List<Student>Get()
        {
            return _dbContext.Students.ToList();
        }



    }
}
