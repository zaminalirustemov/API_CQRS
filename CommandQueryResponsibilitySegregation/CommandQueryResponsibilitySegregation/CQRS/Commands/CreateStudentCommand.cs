using MediatR;

namespace CommandQueryResponsibilitySegregation.CQRS.Commands
{
    public class CreateStudentCommand : IRequest
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
    }
}
