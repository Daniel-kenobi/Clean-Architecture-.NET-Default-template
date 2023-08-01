using CleanArch.Domain.Commons.Error;

namespace CleanArch.Domain.Commons.Responses
{
    public class CommonResponse<T> where T : class
    {
        public CommonResponse() { }

        public CommonResponse(T responseObject)
        {
            ResponseObject = responseObject;
        }

        public bool IsSucessFull { get; private set; } = true;
        public List<WebServiceError> Errors { get; private set; } = new();
        public T ResponseObject { get; set; } = null!;

        public void AddErrors(WebServiceError error)
        {
            Errors.Add(error);
            IsSucessFull = false;
        }
    }

    public class CommonResponse
    {
        public bool IsSucessFull { get; private set; } = true;
        public List<WebServiceError> Errors { get; private set; } = new List<WebServiceError>();

        public void AddErrors(WebServiceError error)
        {
            IsSucessFull = false;
            Errors.Add(error);
        }
    }
}
