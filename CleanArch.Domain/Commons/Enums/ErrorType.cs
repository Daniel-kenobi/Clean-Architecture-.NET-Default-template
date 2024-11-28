namespace CleanArch.Domain.Commons.Enums;

public enum ErrorType
{
    BadRequest = 1,
    NotFound,
    UnprocessableEntity,
    Unspecified,
    Unauthorized,
    CustomError
}
