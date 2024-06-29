using MediatR;
using Models;

namespace CQRS.CRUD;

public record GetStudentByIdQuery(int Id) : IRequest<StudentDetails>;