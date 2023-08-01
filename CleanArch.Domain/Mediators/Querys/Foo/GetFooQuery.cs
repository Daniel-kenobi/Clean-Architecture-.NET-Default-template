using CleanArch.Domain.Commons.Responses;
using CleanArch.Domain.Models.Foo;
using MediatR;

namespace CleanArch.Domain.Mediators.Querys.Foo
{
    public class GetFooQuery : IRequest<CommonResponse<FooModel>>
    {

    }
}
