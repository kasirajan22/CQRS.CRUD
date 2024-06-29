using MediatR;

namespace Commands;

public record DeleteStudentCommand(int Id) : IRequest<int>;