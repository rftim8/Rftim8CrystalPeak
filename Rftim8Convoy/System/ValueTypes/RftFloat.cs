namespace Rftim8Convoy.System.ValueTypes
{
    public class RftFloat
    {
        private static readonly float f0 = 11.11f;

        /// <summary>
        /// ~6-9 precision digits
        /// </summary>
        public RftFloat()
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
            Console.WriteLine($"MinValue: {float.MinValue}");
            Console.WriteLine($"MaxValue: {float.MaxValue}");
            Console.WriteLine($"Bytes: {sizeof(float)}");
            Console.WriteLine($"Bits: {sizeof(float) * 8}");
            Console.WriteLine($"Constant pi: {float.Pi}");
            Console.WriteLine($"Constant e: {float.E}");
            Console.WriteLine($"Constant tau: {float.Tau}");
            Console.WriteLine($"Constant epsilon: {float.Epsilon}");
            Console.WriteLine($"Nan: {float.NaN}");
            Console.WriteLine($"Negative infinity: {float.NegativeInfinity}");
            Console.WriteLine($"Positive infinity: {float.PositiveInfinity}");
            Console.WriteLine($"Negative zero: {float.NegativeZero}");
        }
    }
}
