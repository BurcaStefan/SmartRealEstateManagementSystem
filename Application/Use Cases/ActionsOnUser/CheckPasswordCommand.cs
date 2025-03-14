﻿using Domain.Common;
using MediatR;

namespace Application.Use_Cases.ActionsOnUser
{
    public class CheckPasswordCommand : IRequest<Result<bool>>
    {
        public required string Email { get; set; }
        public required string Password { get; set; }
    }
}
