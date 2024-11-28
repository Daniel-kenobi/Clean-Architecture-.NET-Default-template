namespace CleanArch.Domain.Models.PaginationResponse;

public class PaginationResponseModel<T> where T : class
{
    public PaginationResponseModel(T registers)
    {
        Registers = registers;
    }

    public PaginationResponseModel()
    {

    }

    public T Registers { get; set; } = null!;
    public int TotalPages { get; set; }
    public int TotalRegister { get; set; }
}
