using CommandQueryResponsibilitySegregation.CQRS.Queries;
using CommandQueryResponsibilitySegregation.CQRS.Results;
using CommandQueryResponsibilitySegregation.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CommandQueryResponsibilitySegregation.CQRS.Handlers
{
    public class GetStudentsQueryHandler : IRequestHandler<GetStudentsQuery, IEnumerable<GetStudentsQueryResult>>
    {
        private readonly StudentContext _context;

        public GetStudentsQueryHandler(StudentContext context)
        {
            _context = context;
        }


        public async Task<IEnumerable<GetStudentsQueryResult>> Handle(GetStudentsQuery request, CancellationToken cancellationToken)
        {
            return await _context.Set<Student>().Select(x => new GetStudentsQueryResult
            {
                Name = x.Name,
                Surname = x.Surname,
            }).AsNoTracking().ToListAsync();
        }
    }
}
