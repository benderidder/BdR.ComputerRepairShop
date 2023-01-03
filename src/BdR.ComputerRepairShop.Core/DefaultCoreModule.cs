using Autofac;
using BdR.ComputerRepairShop.Core.Interfaces;
using BdR.ComputerRepairShop.Core.Services;

namespace BdR.ComputerRepairShop.Core;

public class DefaultCoreModule : Module
{
  protected override void Load(ContainerBuilder builder)
  {
    builder.RegisterType<ToDoItemSearchService>()
        .As<IToDoItemSearchService>().InstancePerLifetimeScope();

    builder.RegisterType<DeleteContributorService>()
        .As<IDeleteContributorService>().InstancePerLifetimeScope();
  }
}
