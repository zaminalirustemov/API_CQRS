using CommandQueryResponsibilitySegregation.CQRS.Results;
using MediatR;

namespace CommandQueryResponsibilitySegregation.CQRS.Queries
{
    public class GetStudentsQuery : IRequest<IEnumerable<GetStudentsQueryResult>>
    {
    }
}
