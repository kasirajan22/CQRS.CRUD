using MediatR;

namespace CQRS.CRUD;

public record UpdateStudentCommand(int Id, string StudentName, string StudentEmail, string StudentAddress, int StudentAge) : IRequest<int>;
