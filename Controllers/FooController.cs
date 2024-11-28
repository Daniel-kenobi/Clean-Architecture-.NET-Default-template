namespace CleanArchWebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class FooController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var response = await _mediator.Send(new GetFooQuery());

        if (!response.IsSucessFull)
            return BadRequest(response.Errors);

        return Ok(response.ResponseObject);
    }
}
