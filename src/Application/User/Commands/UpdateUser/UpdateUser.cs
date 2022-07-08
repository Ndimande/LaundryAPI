
using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;


    public partial class UpdateUser : IRequest
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
    }

    public class UpdateUserCommandHandler : IRequestHandler<UpdateUser>
    {
        private readonly IApplicationDbContext _context;

        public UpdateUserCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateUser request, CancellationToken cancellationToken)
        {
            var entity = await _context.SignUp.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(SignUp), request.Id);
            }

            entity.Firstname = request.FirstName;
            entity.Lastname = request.LastName;
            entity.Email = request.Email;
            entity.Password = request.Password;
            entity.Contact = request.Contact;
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }


