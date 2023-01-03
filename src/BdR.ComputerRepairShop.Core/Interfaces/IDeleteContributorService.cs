using Ardalis.Result;

namespace BdR.ComputerRepairShop.Core.Interfaces;

public interface IDeleteContributorService
{
    public Task<Result> DeleteContributor(int contributorId);
}
