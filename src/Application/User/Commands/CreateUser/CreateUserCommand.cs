
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace CA.Application.Students.Commands.CreateStudents
{
    //This command is used to create a new Student
    public class CreateUserCommand : IRequest<int>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
    }

    public class CreateTodoItemCommandHandler : IRequestHandler<CreateUserCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateTodoItemCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var entity = new SignUp
            {
                Firstname = request.FirstName,
                Lastname = request.LastName,
                Email = request.Email,
                Password = request.Password,
                Created = request.CreatedAt.Value,
                Contact = request.Contact,
            };

            _context.SignUp.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
