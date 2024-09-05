namespace Application;

public interface IUseCaseLogger
{
    void Log(UseCaseLog log);
}

public class UseCaseLog
{
    public string Username { get; set; }
    public string UseCaseName { get; set; }
    public object UseCaseData { get; set; }
}