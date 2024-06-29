using System.Windows.Input;
using MediatR;

namespace CQRS.CRUD;

public record CreateStudentCommand(string StudentName, string StudentEmail, string StudentAddress, int StudentAge) : IRequest<StudentDetails>;