using CleanArch.Domain.Commons.Enums;

namespace CleanArch.Domain.Commons.Error
{
    public class WebServiceError
    {
        public WebServiceError(ErrorType ErrorType, string Message, IList<Exception>? Exceptions = null)
        {
            this.ErrorType = ErrorType;
            this.Message = Message;
            this.Exceptions = Exceptions;
        }

        public ErrorType ErrorType { get; private set; }
        public string Message { get; private set; }
        public IList<Exception>? Exceptions { get; private set; }

        public override string ToString()
        {
            return $"{Enum.GetName(typeof(ErrorType), ErrorType)} - {Message}";
        }
    }
}
