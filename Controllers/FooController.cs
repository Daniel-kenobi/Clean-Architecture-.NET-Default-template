using CleanArch.Domain.Mediators.Querys.Foo;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FooController : ControllerBase
    {
        private readonly IMediator _mediator;
        public FooController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _mediator.Send(new GetFooQuery());

            if(!response.IsSucessFull)
                return BadRequest(response.Errors);

            return Ok(response.ResponseObject);
        }
    }
}