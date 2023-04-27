using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AdParser.Application;

public static class ServiceCollection
{
    public static void AddApplication(this IServiceCollection service)
    {
        var assembly = typeof(ServiceCollection).GetTypeInfo().Assembly;
        service.AddMediatR(assembly);
    }
}