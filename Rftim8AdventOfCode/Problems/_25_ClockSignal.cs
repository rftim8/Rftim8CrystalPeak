using BenchmarkDotNet.Attributes;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rftim8Convoy.Services.Host.CP.AdventOfCode.Data;
using Rftim8Convoy.Services.Static.CP.AdventOfCode.Data;

namespace Rftim8AdventOfCode.Problems
{
    public class _25_ClockSignal : I_25_ClockSignal
    {
        #region Static
        private readonly List<string>? data;

        public _25_ClockSignal()
        {
            data = RftAdventOfCodeStaticData.Input_Test(testType: false, problemName: nameof(_25_ClockSignal));
        }

        /// <summary>
        /// You open the door and find yourself on the roof. The city sprawls away from you for miles and miles.
        /// 
        /// There's not much time now - it's already Christmas, but you're nowhere near the North Pole, much too far to deliver these stars to the sleigh in time.
        /// 
        /// However, maybe the huge antenna up here can offer a solution.After all, the sleigh doesn't need the stars, exactly;
        /// it needs the timing data they provide, and you happen to have a massive signal generator right here.
        /// 
        /// You connect the stars you have to your prototype computer, connect that to the antenna, and begin the transmission.
        /// 
        /// Nothing happens.
        /// 
        /// You call the service number printed on the side of the antenna and quickly explain the situation.
        /// "I'm not sure what kind of equipment you have connected over there," he says, "but you need a clock signal." You try to explain that this is a signal for a clock.
        /// 
        /// "No, no, a clock signal - timing information so the antenna computer knows how to read the data you're sending it. 
        /// An endless, alternating pattern of 0, 1, 0, 1, 0, 1, 0, 1, 0, 1...." He trails off.
        /// You ask if the antenna can handle a clock signal at the frequency you would need to use for the data from the stars. 
        /// "There's no way it can! The only antenna we've installed capable of that is on top of a top-secret Easter Bunny installation, and you're definitely not-" You hang up the phone.
        /// You've extracted the antenna's clock signal generation assembunny code (your puzzle input); it looks mostly compatible with code you worked on just recently.
        /// 
        /// This antenna code, being a signal generator, uses one extra instruction:
        /// 
        /// out x transmits x(either an integer or the value of a register) as the next value for the clock signal.
        /// The code takes a value(via register a) that describes the signal to generate, but you're not sure how it's used.
        /// You'll have to find the input to produce the right signal through experimentation.
        /// 
        /// What is the lowest positive integer that can be used to initialize register a and cause the code to output a clock signal of 0, 1, 0, 1... repeating forever?
        /// </summary>
        [Benchmark]
        public int PartOne() => PartOne0(data!);

        private static int PartOne0(List<string> data)
        {
            return 0;
        }
        #endregion

        #region UnitTest
        public static int PartOne_Test(List<string> data) => PartOne0(data);
        #endregion

        #region Host
        private readonly IRftAdventOfCodeHostData? RftAdventOfCodeHostData;

        public _25_ClockSignal(IHost host)
        {
            RftAdventOfCodeHostData = host.Services.GetRequiredService<IRftAdventOfCodeHostData>();
            data = RftAdventOfCodeHostData.Input_Test(problemName: nameof(_25_ClockSignal));
        }

        public void PrintSolution()
        {
            Console.WriteLine(PartOne());
        }
        #endregion
    }
}