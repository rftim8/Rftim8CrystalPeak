using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.LeetCode.Data;
using Rftim8LeetCode.Problems;

namespace Rftim8LeetCode.CP
{
    internal class CPHostMain
    {
        public static async Task InitHost(string[] args)
        {
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);
            builder.Services.AddSingleton<ICPHostBase, CPHostBase>();

            #region LeetCode
            builder.Services.AddSingleton<IRftLeetCodeHostData, RftLeetCodeHostData>();

            builder.Services.AddSingleton<ILC_00000001_TwoSum, LC_00000001_TwoSum>();
            builder.Services.AddSingleton<ILC_00000036_ValidSudoku, LC_00000036_ValidSudoku>();
            builder.Services.AddSingleton<ILC_00003688_BitwiseOROfEvenNumbersInAnArray, LC_00003688_BitwiseOROfEvenNumbersInAnArray>();
            builder.Services.AddSingleton<ILC_00003689_MaximumTotalSubarrayValueI, LC_00003689_MaximumTotalSubarrayValueI>();
            builder.Services.AddSingleton<ILC_00003690_SplitAndMergeArrayTransformation, LC_00003690_SplitAndMergeArrayTransformation>();
            builder.Services.AddSingleton<ILC_00003691_MaximumTotalSubarrayValueII, LC_00003691_MaximumTotalSubarrayValueII>();
            #endregion

            #region EFCore

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
