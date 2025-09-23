using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8AdventOfCode.Problems;
using Rftim8Convoy.Services.Host.CP.AdventOfCode.Data;

namespace Rftim8AdventOfCode.CP
{
    internal class CPHostMain
    {
        public static async Task InitHost(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton<ICPHostBase, CPHostBase>();

            builder.Services.AddSingleton<IRftAtCoderJPHostData, RftAtOfCoderJPHostData>();

            #region AdventOfCode
            builder.Services.AddSingleton<IAOC_00000001_Y15_NotQuiteLisp, AOC_00000001_Y15_NotQuiteLisp>();
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
