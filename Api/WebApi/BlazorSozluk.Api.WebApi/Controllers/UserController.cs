﻿using BlazorSozlukCommon.ViewModels.RequestModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorSozluk.Api.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator mediator;
        public UserController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody]LoginUserCommand loginUserCommand)
        {
            var result = await mediator.Send(loginUserCommand);
            
            return Ok(result);
        }
    }
}