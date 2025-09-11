namespace Rftim8Convoy.System.ValueTypes
{
    internal class RftDouble
    {
        private static readonly double d0 = 11.11;

        /// <summary>
        /// ~15-17 decimal digits of precision
        /// 
        /// Double is the default for floating point numbers in C# (if not specified after value)
        /// </summary>
        public RftDouble()
        {
            int func = 0;

            switch (func)
            {
                case 0:
                    Properties();
                    break;
                default:
                    break;
            }
        }

        private static void Properties()
        {
            Console.WriteLine($"MinValue: {double.MinValue}");
            Console.WriteLine($"MaxValue: {double.MaxValue}");
            Console.WriteLine($"Bytes: {sizeof(double)}");
            Console.WriteLine($"Bits: {sizeof(double) * 8}");
            Console.WriteLine($"Constant pi: {double.Pi}");
            Console.WriteLine($"Constant e: {double.E}");
            Console.WriteLine($"Constant tau: {double.Tau}");
            Console.WriteLine($"Constant epsilon: {double.Epsilon}");
            Console.WriteLine($"Nan: {double.NaN}");
            Console.WriteLine($"Negative infinity: {double.NegativeInfinity}");
            Console.WriteLine($"Positive infinity: {double.PositiveInfinity}");
            Console.WriteLine($"Negative zero: {double.NegativeZero}");
            Console.WriteLine($"Variable type: {d0.GetTypeCode()}");
        }
    }
}
