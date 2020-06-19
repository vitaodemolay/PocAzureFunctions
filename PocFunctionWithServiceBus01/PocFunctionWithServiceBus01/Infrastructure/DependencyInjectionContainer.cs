using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

namespace PocFunctionWithServiceBus01.Infrastructure
{
    public sealed class DependencyInjectionContainer
    {
        private static readonly IServiceProvider _serviceProvider = BuildServiceProvider();
        private static readonly IConfigurationRoot _configurationRoot = BuildConfigurationRoot();
        public static IServiceProvider Instance => _serviceProvider;
        public static IConfigurationRoot Configuration => _configurationRoot;

        private static IConfigurationRoot BuildConfigurationRoot()
        {
            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("local.settings.json", optional: true, reloadOnChange: true)
               .AddEnvironmentVariables()
               .Build();

            return configuration;
        }

        private static IServiceProvider BuildServiceProvider()
        {
            var services = new ServiceCollection();
          
            return services.BuildServiceProvider();
        }

        private DependencyInjectionContainer() { }
    }
}
