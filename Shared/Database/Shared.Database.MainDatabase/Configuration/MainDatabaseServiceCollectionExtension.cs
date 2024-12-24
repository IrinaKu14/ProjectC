using Microsoft.Extensions.DependencyInjection;
using Shared.Database.MainDatabase.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Database.MainDatabase.Configuration;

public static class MainDatabaseServiceCollectionExtension
{
    public static void AddMainDataBase(this IServiceCollection services)
    {
        services.AddSingleton<MainDbContext>();

        services.AddScoped<UserRepository>();
    }
}
