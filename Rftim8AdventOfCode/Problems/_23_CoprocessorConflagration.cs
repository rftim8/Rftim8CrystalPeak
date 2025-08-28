using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.AdventOfCode.Data;
using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;

namespace Rftim8AdventOfCode.Problems
{
    public class _23_CoprocessorConflagration : I_23_CoprocessorConflagration
    {
        #region Static
        private readonly List<string>? data;

        public _23_CoprocessorConflagration()
        {
            data = RftAdventOfCodeStaticData.Input_Test(testType: false, problemName: nameof(_23_CoprocessorConflagration));
        }

        /// <summary>
        /// You decide to head directly to the CPU and fix the printer from there.
        /// As you get close, you find an experimental coprocessor doing so much work that the local programs are afraid it will halt and catch fire. 
        /// This would cause serious issues for the rest of the computer, so you head in and see what you can do.
        /// 
        /// The code it's running seems to be a variant of the kind you saw recently on that tablet.
        /// The general functionality seems very similar, but some of the instructions are different:
        /// 
        /// set X Y sets register X to the value of Y.
        /// sub X Y decreases register X by the value of Y.
        /// mul X Y sets register X to the result of multiplying the value contained in register X by the value of Y.
        /// jnz X Y jumps with an offset of the value of Y, but only if the value of X is not zero.
        /// (An offset of 2 skips the next instruction, an offset of -1 jumps to the previous instruction, and so on.)
        /// Only the instructions listed above are used.The eight registers here, named a through h, all start at 0.
        /// 
        /// The coprocessor is currently set to some kind of debug mode, which allows for testing, but prevents it from doing any meaningful work.
        /// 
        /// If you run the program (your puzzle input), how many times is the mul instruction invoked?
        /// </summary>
        [Benchmark]
        public int PartOne() => PartOne0(data!);

        private static int PartOne0(List<string> data)
        {
            return 0;
        }

        /// <summary>
        /// Now, it's time to fix the problem.
        /// 
        /// The debug mode switch is wired directly to register a.You flip the switch, which makes register a now start at 1 when the program is executed.
        /// Immediately, the coprocessor begins to overheat.Whoever wrote this program obviously didn't choose a very efficient implementation. 
        /// You'll need to optimize the program if it has any hope of completing before Santa needs that printer working.
        /// The coprocessor's ultimate goal is to determine the final value left in register h once the program completes. 
        /// Technically, if it had that... it wouldn't even need to run the program.
        /// After setting register a to 1, if the program were to run to completion, what value would be left in register h?
        /// </summary>        
        [Benchmark]
        public int PartTwo() => PartTwo0(data!);

        private static int PartTwo0(List<string> data)
        {
            return 0;
        }
        #endregion

        #region UnitTest
        public static int PartOne_Test(List<string> data) => PartOne0(data);

        public static int PartTwo_Test(List<string> data) => PartTwo0(data);
        #endregion

        #region Host
        private readonly IRftAdventOfCodeHostData? RftAdventOfCodeHostData;

        public _23_CoprocessorConflagration(IHost host)
        {
            RftAdventOfCodeHostData = host.Services.GetRequiredService<IRftAdventOfCodeHostData>();
            data = RftAdventOfCodeHostData.Input_Test(problemName: nameof(_23_CoprocessorConflagration));
        }

        public void PrintSolution()
        {
            Console.WriteLine(PartOne());
            Console.WriteLine(PartTwo());
        }
        #endregion
    }
}