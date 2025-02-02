using Microsoft.Extensions.DependencyInjection;
using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Cache.Redis.Configuration
{
    public static class RedisCacheServiceCollectionExtensions
    {
        public static void AddRedisCache(this IServiceCollection services)
        {
            var redOpt = new ConfigurationOptions()
            {
                EndPoints = { "localhost:6379" },
                AbortOnConnectFail = false,
            };
           var mp = ConnectionMultiplexer.Connect(redOpt);
            services.AddSingleton(mp);

            services.AddSingleton<ICacher, Cacher>();
        }

       
    }
}
