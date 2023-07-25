using CommandQueryResponsibilitySegregation.CQRS.Results;
using MediatR;

namespace CommandQueryResponsibilitySegregation.CQRS.Queries
{
    public class GetStudentByIdQuery : IRequest<GetStudentByIdQueryResult>
    {
        public GetStudentByIdQuery(int ıd)
        {
            Id = ıd;
        }

        public int Id { get; set; }
    }
}
