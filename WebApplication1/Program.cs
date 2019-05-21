using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Unity;
using Unity.Lifetime;
using Unity.Microsoft.DependencyInjection;
using WebApplication1.Services;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args)
        {
            var container = new UnityContainer();

            container.RegisterType(typeof(IStorageService<>), typeof(StorageService<>), new SingletonLifetimeManager());
            container.RegisterType<IDataService, DataService>(new TransientLifetimeManager());

            return WebHost.CreateDefaultBuilder(args)
                .UseUnityServiceProvider(container)
                .UseStartup<Startup>();
        }
    }
}
