using Application.UseCases;

namespace Application;

public interface IQuery<TResult, TSearch> : IUseCase
    where TResult : class
{
    TResult Execute(TSearch search);
}