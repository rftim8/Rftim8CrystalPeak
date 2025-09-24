using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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

            #region LeetCode            
            //ILC_00000036_ValidSudoku lC_00000036_ValidSudoku = serviceProvider.GetRequiredService<ILC_00000036_ValidSudoku>();
            //lC_00000036_ValidSudoku.PrintSolution();

            ILC_00003688_BitwiseOROfEvenNumbersInAnArray lC_00003688_BitwiseOROfEvenNumbersInAnArray = serviceProvider.GetRequiredService<ILC_00003688_BitwiseOROfEvenNumbersInAnArray>();
            lC_00003688_BitwiseOROfEvenNumbersInAnArray.PrintSolution();
            #endregion

        }
    }
}
