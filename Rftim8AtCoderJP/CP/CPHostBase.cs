using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
//using Rftim8AtCoderJP.Problems;

namespace Rftim8AtCoderJP.CP
{
    internal class CPHostBase : ICPHostBase
    {
        public void RunCPHostBase(IHost host) => RunCPHostBase0(host.Services);

        private static void RunCPHostBase0(IServiceProvider hostProvider)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            #region LeetCode
            //ILC_00000001_TwoSum i_00001_TwoSum = serviceProvider.GetRequiredService<ILC_00000001_TwoSum>();
            //i_00001_TwoSum.PrintSolution();
            #endregion

        }
    }
}
