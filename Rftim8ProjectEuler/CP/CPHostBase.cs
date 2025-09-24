using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8ProjectEuler.Problems;

namespace Rftim8ProjectEuler.CP
{
    internal class CPHostBase : ICPHostBase
    {
        public void RunCPHostBase(IHost host) => RunCPHostBase0(host.Services);

        private static void RunCPHostBase0(IServiceProvider hostProvider)
        {
            using IServiceScope serviceScope = hostProvider.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            #region ProjectEuler
            IPE_00000002_EvenFibonacciNumbers pE_00000002_EvenFibonacciNumbers = serviceProvider.GetRequiredService<IPE_00000002_EvenFibonacciNumbers>();
            pE_00000002_EvenFibonacciNumbers.PrintSolution();
            #endregion
        }
    }
}
