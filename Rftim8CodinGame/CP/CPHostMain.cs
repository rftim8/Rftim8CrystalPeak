using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8CodinGame.Problems;
using Rftim8Convoy.Services.Host.CP.CodinGame.Data;

namespace Rftim8CodinGame.CP
{
    internal class CPHostMain
    {
        public static async Task InitHost(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton<ICPHostBase, CPHostBase>();

            builder.Services.AddSingleton<IRftCodinGameHostData, RftCodinGameHostData>();

            #region CodinGame
            builder.Services.AddSingleton<ICG_00000001_1000000000DWORLD, CG_00000001_1000000000DWORLD>();
            #endregion

            IHost host = builder.Build();

            await host.StartAsync();

            ICPHostBase cPHostBase = host.Services.GetRequiredService<ICPHostBase>();
            cPHostBase.RunCPHostBase(host);

            await ShutdownHost(host);
        }

        public static async Task ShutdownHost(IHost host)
        {
            host.Dispose();
            await host.StopAsync();
        }
    }
}
