using CQRS_Mediator.Library.Commands;
using CQRS_Mediator.Library.DataAccess;
using CQRS_Mediator.Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.Handlers
{
    public class AddStudentHandler : IRequestHandler<AddStudentCommand, Student>
    {
        private readonly IDataAccess _data;
        public AddStudentHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<Student> Handle(AddStudentCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.AddStudent(request.firstName, request.lastName, request.age));
        }
    }
}
