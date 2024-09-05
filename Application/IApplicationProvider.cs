namespace Application;

public interface IApplicationProvider
{
    IApplicationActor GetActor();
}