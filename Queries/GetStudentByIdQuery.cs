using MediatR;

namespace CQRS.CRUD;

public record GetStudentByIdQuery(int Id) : IRequest<StudentDetails>;