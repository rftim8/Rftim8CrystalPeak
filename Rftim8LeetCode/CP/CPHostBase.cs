using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Static.IO;
using Rftim8LeetCode.Problems;

namespace Rftim8LeetCode.CP
{
    internal class CPHostBase : ICPHostBase
    {
        public void RunCPHostBase(IHost host) => RunCPHostBase0(host.Services);

        private static void RunCPHostBase0(IServiceProvider hostProvider)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            //RftFileContentManager.GetLeetCodeProblemNames();
            //RftFileContentManager.CreateLeetCodeDataFiles(RftFileContentManager.GetLeetCodeProblemNames());
            //RftFileContentManager.CreateLeetCodeCodeInterfaceFiles(RftFileContentManager.GetLeetCodeProblemNames());
            //RftFileContentManager.CreateLeetCodeCodeFiles(RftFileContentManager.GetLeetCodeProblemNames());
            //RftFileContentManager.CreateLeetCodexUnitTestFiles(RftFileContentManager.GetLeetCodeProblemNames());

            #region LeetCode
            //ILC_00000001_TwoSum i_00001_TwoSum = serviceProvider.GetRequiredService<ILC_00000001_TwoSum>();
            //i_00001_TwoSum.PrintSolution();

            ILC_00000036_ValidSudoku lC_00000036_ValidSudoku = serviceProvider.GetRequiredService<ILC_00000036_ValidSudoku>();
            lC_00000036_ValidSudoku.PrintSolution();
            #endregion

        }
    }
}
