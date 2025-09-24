using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.ProjectEuler.Data;
using Rftim8ProjectEuler.Problems;

namespace Rftim8ProjectEuler.CP
{
    internal class CPHostMain
    {
        public static async Task InitHost(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton<ICPHostBase, CPHostBase>();

            builder.Services.AddSingleton<IRftProjectEulerHostData, RftProjectEulerHostData>();

            #region LeetCode
            builder.Services.AddSingleton<PE_00000002_EvenFibonacciNumbers, PE_00000002_EvenFibonacciNumbers>();
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
