using Ardalis.Specification;

namespace BdR.ComputerRepairShop.SharedKernel.Interfaces;

// from Ardalis.Specification
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
