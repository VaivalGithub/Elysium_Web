using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SERVICES.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VulcanForged.CMS.Admin.Helper.DI
{
    public static class ContainerConfig
    {
        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {

            IConfigurationRoot configuration = new ConfigurationBuilder()
                                                         .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                                         .AddJsonFile("appsettings.json")
                                                         .Build();
            services.AddScoped<IUOW, UOW>();
        }
    }
}
