using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UploadService.DataAccess.Concrete.EntityFramework;

namespace UploadService.Business.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddBusinessRegistrarion(this IServiceCollection services)
        {
            services.AddScoped<AppDbContext>();
        }
    }
}
