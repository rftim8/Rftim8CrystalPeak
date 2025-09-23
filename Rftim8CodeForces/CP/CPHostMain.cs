using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8CodeForces.Problems;
using Rftim8Convoy.Services.Host.CP.AdventOfCode.Data;
using Rftim8Convoy.Services.Host.CP.CodeForces.Data;

namespace Rftim8CodeForces.CP
{
    internal class CPHostMain
    {
        public static async Task InitHost(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton<ICPHostBase, CPHostBase>();

            builder.Services.AddSingleton<IRftCodeForcesHostData,RftCodeForcesHostData>();

            #region CodeForces
            builder.Services.AddSingleton<ICF_00000002A_Winner, CF_00000002A_Winner>();
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
