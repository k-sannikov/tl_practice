namespace Example9;

public class DiscountResult
{
    public bool IsSuccess { get; }
    public double Result { get; }
    public string? ErrorMessage { get; }

    public DiscountResult(bool isSuccess, string errorMessage)
    {
        IsSuccess = isSuccess;
        ErrorMessage = errorMessage;
    }

    public DiscountResult(double result)
    {
        Result = result;
    }
}
