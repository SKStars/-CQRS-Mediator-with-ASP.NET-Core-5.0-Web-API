using CQRS_Mediator.Library.DataAccess;
using CQRS_Mediator.Library.Models;
using CQRS_Mediator.Library.Queries;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS_Mediator.Library.Handlers
{
    public class GetStudentListHandler : IRequestHandler<GetStudentListQuery, List<Student>>
    {
        private readonly IDataAccess _data;
        public GetStudentListHandler(IDataAccess data)
        {
            _data = data;
        }
        public Task<List<Student>> Handle(GetStudentListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetStudents());
        }
    }
}
