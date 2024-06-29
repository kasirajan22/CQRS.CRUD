using MediatR;
using Models;

namespace Queries;

public record GetStudentByIdQuery(int Id) : IRequest<StudentDetails>;