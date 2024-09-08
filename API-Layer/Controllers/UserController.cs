﻿using Application_Layer.Commands.UserCommands;
using Application_Layer.Commands.UserCommands.Login;
using Application_Layer.DTO_s;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace API_Layer.Controllers
{
    public class UserController : Controller
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;   
        }

        [AllowAnonymous]
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO registerUserDTO)
        {
           var result = await _mediator.Send(new RegisterUserCommand(registerUserDTO));

            if (!result.Success)
            {
                return BadRequest(result.Errors);
            }

            return Ok(result.CreatedUser);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO loginUserDTO)
        {
            var command = new LoginCommand(loginUserDTO);
            var result = await _mediator.Send(command);

            if (!result.Successful)
            {
                return BadRequest(result.Error);
            }

            return Ok(new { token = result.Token });
        }
    }
}
