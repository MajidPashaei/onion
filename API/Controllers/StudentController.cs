using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Domain;
using Core.Interface.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudent _Student;
        public StudentController(IStudent student)
        {
            _Student= student;
        }
        [HttpGet]
        public List<MStudent> GetTModel()
        {
            return _Student.GetAllStudent();
        }
    }
}
