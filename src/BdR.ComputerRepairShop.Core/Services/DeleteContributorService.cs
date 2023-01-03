using Ardalis.Result;
using BdR.ComputerRepairShop.Core.ContributorAggregate;
using BdR.ComputerRepairShop.Core.ContributorAggregate.Events;
using BdR.ComputerRepairShop.Core.Interfaces;
using BdR.ComputerRepairShop.SharedKernel.Interfaces;
using MediatR;

namespace BdR.ComputerRepairShop.Core.Services;

public class DeleteContributorService : IDeleteContributorService
{
  private readonly IRepository<Contributor> _repository;
  private readonly IMediator _mediator;

  public DeleteContributorService(IRepository<Contributor> repository, IMediator mediator)
  {
    _repository = repository;
    _mediator = mediator;
  }

  public async Task<Result> DeleteContributor(int contributorId)
  {
    var aggregateToDelete = await _repository.GetByIdAsync(contributorId);
    if (aggregateToDelete == null) return Result.NotFound();

    await _repository.DeleteAsync(aggregateToDelete);
    var domainEvent = new ContributorDeletedEvent(contributorId);
    await _mediator.Publish(domainEvent);
    return Result.Success();
  }
}
