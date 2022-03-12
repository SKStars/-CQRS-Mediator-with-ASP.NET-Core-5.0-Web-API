using CQRS_Mediator.Library.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.Commands
{
    public record AddStudentCommand(string firstName, string lastName, double age) : IRequest<Student>;
}
