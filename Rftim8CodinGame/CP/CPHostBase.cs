using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8CodinGame.Problems;

namespace Rftim8CodinGame.CP
{
    internal class CPHostBase : ICPHostBase
    {
        public void RunCPHostBase(IHost host) => RunCPHostBase0(host.Services);

        private static void RunCPHostBase0(IServiceProvider hostProvider)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            #region CodinGame
            //IAOC_00000001_Y15_NotQuiteLisp aOC_00000001_Y15_NotQuiteLisp = serviceProvider.GetRequiredService<IAOC_00000001_Y15_NotQuiteLisp>();
            //aOC_00000001_Y15_NotQuiteLisp.PrintSolution();
            #endregion
        }
    }
}