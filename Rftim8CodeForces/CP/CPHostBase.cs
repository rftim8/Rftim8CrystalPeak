using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8CodeForces.Problems;

namespace Rftim8CodeForces.CP
{
    internal class CPHostBase : ICPHostBase
    {
        public void RunCPHostBase(IHost host) => RunCPHostBase0(host.Services);

        private static void RunCPHostBase0(IServiceProvider hostProvider)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            #region CodeForces
            ICF_00000002A_Winner cF_00000002A_Winner = serviceProvider.GetRequiredService<ICF_00000002A_Winner>();
            cF_00000002A_Winner.PrintSolution();
            #endregion
        }
    }
}