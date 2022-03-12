using CQRS_Mediator.Library.Commands;
using CQRS_Mediator.Library.Models;
using CQRS_Mediator.Library.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS_Mediator.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<Student>> Get()
        {
            return await _mediator.Send(new GetStudentListQuery());
        }

        [HttpGet("{id}")]
        public async Task<Student> Get(int id)
        {
            return await _mediator.Send(new GetStudentByIdQuery(id));
        }

        [HttpPost]
        public async Task<Student> Post([FromBody] Student value)
        {
            var model = new AddStudentCommand(value.FirstName, value.LastName, value.Age);
            return await _mediator.Send(model);
        }
    }
}
