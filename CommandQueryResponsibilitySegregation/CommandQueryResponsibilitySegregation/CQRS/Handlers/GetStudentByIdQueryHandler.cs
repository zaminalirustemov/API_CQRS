using CommandQueryResponsibilitySegregation.CQRS.Queries;
using CommandQueryResponsibilitySegregation.CQRS.Results;
using CommandQueryResponsibilitySegregation.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CommandQueryResponsibilitySegregation.CQRS.Handlers
{
    public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, GetStudentByIdQueryResult>
    {
        private readonly StudentContext _context;

        public GetStudentByIdQueryHandler(StudentContext context)
        {
            _context = context;
        }


        public async Task<GetStudentByIdQueryResult> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            Student student = await _context.Set<Student>().FirstOrDefaultAsync(x => x.Id == request.Id);
            GetStudentByIdQueryResult result = new()
            {
                Name = student.Name,
                Surname = student.Surname,
                Age = student.Age,
            };
            return result;
        }
    }
}
