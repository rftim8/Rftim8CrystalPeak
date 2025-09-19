using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8AdventOfCode.Problems;

namespace Rftim8AdventOfCode.CP
{
    internal class CPHostBase : ICPHostBase
    {
        public void RunCPHostBase(IHost host) => RunCPHostBase0(host.Services);

        private static void RunCPHostBase0(IServiceProvider hostProvider)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            //RftFileContentManager.GetAdventOfCodeProblemNames();
            //RftFileContentManager.CreateAdventOfCodeDataFiles(RftFileContentManager.GetAdventOfCodeProblemNames());
            //RftFileContentManager.CreateAdventOfCodeCodeInterfaceFiles(RftFileContentManager.GetAdventOfCodeProblemNames());
            //RftFileContentManager.CreateAdventOfCodeCodeFiles(RftFileContentManager.GetAdventOfCodeProblemNames());
            //RftFileContentManager.CreateAdventOfCodexUnitTestFiles(RftFileContentManager.GetAdventOfCodeProblemNames());

            #region AdventOfCode
            IAOC_00000001_Y15_NotQuiteLisp aOC_00000001_Y15_NotQuiteLisp = serviceProvider.GetRequiredService<IAOC_00000001_Y15_NotQuiteLisp>();
            aOC_00000001_Y15_NotQuiteLisp.PrintSolution();
            #endregion
        }
    }
}