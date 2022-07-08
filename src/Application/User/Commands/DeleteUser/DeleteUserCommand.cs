
using CleanArchitecture.Application.Common.Exceptions;
using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CA.Application.Students.Commands.DeleteStudent
{
    public class DeleteUserCommand : IRequest
    {
        public int Id { get; set; }
    }

    public class DeleteStudentCommandHandler : IRequestHandler<DeleteUserCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteStudentCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.SignUp.FindAsync(request.Id);

            if (entity == null)
            {
                throw new NotFoundException(nameof(SignUp), request.Id);
            }

            _context.SignUp.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
