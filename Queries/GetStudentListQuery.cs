using MediatR;

namespace CQRS.CRUD;

public class GetStudentListQuery() :  IRequest<List<StudentDetails>>;