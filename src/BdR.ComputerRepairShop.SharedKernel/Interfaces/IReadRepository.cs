using Ardalis.Specification;

namespace BdR.ComputerRepairShop.SharedKernel.Interfaces;

public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
}
