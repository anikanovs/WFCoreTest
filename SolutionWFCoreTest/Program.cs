using System;
using WorkflowCore.Interface;
using Microsoft.Extensions.DependencyInjection;
using WorkflowCore.Services;

namespace SolutionWFCoreTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();
            var host = serviceProvider.GetService<IWorkflowHost>();            
            host.RegisterWorkflow<MyWorkflow>();
            host.Start();

            host.StartWorkflow("HelloWorld", 1, null);

            Console.ReadLine();

        }
        
        private static IServiceProvider ConfigureServices()
        {
            //setup dependency injection
            IServiceCollection services = new ServiceCollection();
            services.AddLogging();
            services.AddWorkflow(x => x.UsePostgreSQL(@"Server=127.0.0.1;Port=5432;Database=WorkflowDB;User Id=postgres;Password=sa", true, true));
            
            //services.AddTransient<DoSomething>();
            services.AddTransient<IWorkflowHost, MyWorkflowHost>();

            var serviceProvider = services.BuildServiceProvider();

            return serviceProvider;
        }
    }
}
