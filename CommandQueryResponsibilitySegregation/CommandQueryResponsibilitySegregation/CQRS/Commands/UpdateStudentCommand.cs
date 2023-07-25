using MediatR;

namespace CommandQueryResponsibilitySegregation.CQRS.Commands
{
    public class UpdateStudentCommand : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
    }
}
