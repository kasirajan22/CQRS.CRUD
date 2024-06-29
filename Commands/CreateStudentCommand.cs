using System.Windows.Input;
using MediatR;
using Models;

namespace Commands;

public record CreateStudentCommand(string StudentName, string StudentEmail, string StudentAddress, int StudentAge) : IRequest<StudentDetails>;