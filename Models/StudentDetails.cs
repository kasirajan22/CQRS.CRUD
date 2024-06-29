using System.ComponentModel.DataAnnotations;

namespace Models;

public class StudentDetails
    {
        public int Id { get; set; }
        public required string StudentName { get; set; }
        public required string StudentEmail { get; set; }
        public required string StudentAddress { get; set; }
        public int StudentAge { get; set; }
    }
