namespace Example8;

public class AgeException : Exception
{
    public int Age { get; }

    public AgeException(int age) : base()
    {
        Age = age;
    }

    public AgeException(string message, int age) : base(message)
    {
        Age = age;
    }

    public AgeException(string message, Exception innerException, int age) : base(message, innerException)
    {
        Age = age;
    }
}
