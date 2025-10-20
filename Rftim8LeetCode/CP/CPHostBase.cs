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

            //ILC_00003688_BitwiseOROfEvenNumbersInAnArray lC_00003688_BitwiseOROfEvenNumbersInAnArray = serviceProvider.GetRequiredService<ILC_00003688_BitwiseOROfEvenNumbersInAnArray>();
            //lC_00003688_BitwiseOROfEvenNumbersInAnArray.PrintSolution();

            //ILC_00003689_MaximumTotalSubarrayValueI lC_00003689_MaximumTotalSubarrayValueI = serviceProvider.GetRequiredService<ILC_00003689_MaximumTotalSubarrayValueI>();
            //lC_00003689_MaximumTotalSubarrayValueI.PrintSolution();

            //ILC_00003690_SplitAndMergeArrayTransformation lC_00003690_SplitAndMergeArrayTransformation = serviceProvider.GetRequiredService<ILC_00003690_SplitAndMergeArrayTransformation>();
            //lC_00003690_SplitAndMergeArrayTransformation.PrintSolution();

            ILC_00003691_MaximumTotalSubarrayValueII lC_00003691_MaximumTotalSubarrayValueII = serviceProvider.GetRequiredService<ILC_00003691_MaximumTotalSubarrayValueII>();
            lC_00003691_MaximumTotalSubarrayValueII.PrintSolution();
            #endregion
        }
    }
}
