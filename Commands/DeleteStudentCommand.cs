using MediatR;

namespace CQRS.CRUD;

public record DeleteStudentCommand(int Id) : IRequest<int>;