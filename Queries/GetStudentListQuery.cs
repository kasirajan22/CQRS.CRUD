using MediatR;
using Models;

namespace CQRS.CRUD;

public class GetStudentListQuery() :  IRequest<List<StudentDetails>>;