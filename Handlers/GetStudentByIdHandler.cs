﻿using MediatR;
using Models;
using Queries;
using Repository;

namespace Handlers;

public class GetStudentByIdHandler : IRequestHandler<GetStudentByIdQuery, StudentDetails?>
    {
        private readonly IStudentRepository _studentRepository;

        public GetStudentByIdHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentDetails?> Handle(GetStudentByIdQuery query, CancellationToken cancellationToken)
        {
            return await _studentRepository.GetStudentByIdAsync(query.Id);
        }
    }