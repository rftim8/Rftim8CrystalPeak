using Rftim8Convoy.InfiniSwiss.Engineering.Generic;

namespace Rftim8CrystalPeak
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ArgumentNullException.ThrowIfNull(args);
            
            _ = new RftCodeReviewMethodologies();
        }
    }
}
