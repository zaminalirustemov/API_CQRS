using CommandQueryResponsibilitySegregation.CQRS.Commands;
using CommandQueryResponsibilitySegregation.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace CommandQueryResponsibilitySegregation.CQRS.Handlers
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand>
    {
        private readonly StudentContext _context;

        public UpdateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            Student updatedStudent = await _context.Students.FirstOrDefaultAsync(x => x.Id == request.Id);
            updatedStudent.Name = request.Name;
            updatedStudent.Surname = request.Surname;
            updatedStudent.Age = request.Age;
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
