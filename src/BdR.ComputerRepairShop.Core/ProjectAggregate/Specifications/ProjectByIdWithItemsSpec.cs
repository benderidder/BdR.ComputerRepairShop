using Ardalis.Specification;
using BdR.ComputerRepairShop.Core.ProjectAggregate;

namespace BdR.ComputerRepairShop.Core.ProjectAggregate.Specifications;

public class ProjectByIdWithItemsSpec : Specification<Project>, ISingleResultSpecification
{
  public ProjectByIdWithItemsSpec(int projectId)
  {
    Query
        .Where(project => project.Id == projectId)
        .Include(project => project.Items);
  }
}
