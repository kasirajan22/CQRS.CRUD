using MediatR;
using Models;

namespace Queries;

public class GetStudentListQuery() :  IRequest<List<StudentDetails>>;