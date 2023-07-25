using CommandQueryResponsibilitySegregation.CQRS.Commands;
using CommandQueryResponsibilitySegregation.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CommandQueryResponsibilitySegregation.CQRS.Handlers
{
    public class RemoveStudentCommandHandler : IRequestHandler<RemoveStudentCommand>
    {
        private readonly StudentContext _context;

        public RemoveStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(RemoveStudentCommand request, CancellationToken cancellationToken)
        {
            Student deletedStudent = await _context.Students.FirstOrDefaultAsync(x => x.Id == request.Id);
            _context.Students.Remove(deletedStudent);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
