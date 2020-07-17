using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloodDonation.WebAPI.DependencyInjection
{
    public static class ServiceDependency
    {
        public static IServiceCollection AddDependencyInjuction(this IServiceCollection service)
        {
            //service.AddScoped<>
            return service;
        }
    }
}
