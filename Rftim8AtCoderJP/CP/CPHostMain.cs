using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.AtCoderJP.Data;
//using Rftim8AtCoderJP.Problems;

namespace Rftim8AtCoderJP.CP
{
    internal class CPHostMain
    {
        public static async Task InitHost(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton<ICPHostBase, CPHostBase>();

            builder.Services.AddSingleton<IRftAtCoderJPHostData, RftAtOfCoderJPHostData>();

            #region AtCoderJP
            //builder.Services.AddSingleton<ILC_00000001_TwoSum, LC_00000001_TwoSum>();
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
