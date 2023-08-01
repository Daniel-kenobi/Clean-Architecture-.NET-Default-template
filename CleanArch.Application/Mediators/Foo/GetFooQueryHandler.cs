using CleanArch.Domain.Commons.Responses;
using CleanArch.Domain.Mediators.Querys.Foo;
using CleanArch.Domain.Models.Foo;
using MediatR;

namespace CleanArch.Application.Mediators.Foo
{
    public class GetFooQueryHandler : IRequestHandler<GetFooQuery, CommonResponse<FooModel>>
    {
        public Task<CommonResponse<FooModel>> Handle(GetFooQuery request, CancellationToken cancellationToken)
        {
            var response = new CommonResponse<FooModel>
            {
                ResponseObject = new FooModel()
                {
                    Id = 1,
                    Name = "Foo"
                }
            };

            return Task.FromResult(response);
        }
    }
}
