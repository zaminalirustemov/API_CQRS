using CommandQueryResponsibilitySegregation.CQRS.Commands;
using CommandQueryResponsibilitySegregation.Data;
using MediatR;

namespace CommandQueryResponsibilitySegregation.CQRS.Handlers
{
    public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand>
    {
        private readonly StudentContext _context;

        public CreateStudentCommandHandler(StudentContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            Student student = new()
            {
                Name = request.Name,
                Surname = request.Surname,
                Age = request.Age
            };
            await _context.Students.AddAsync(student);
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
