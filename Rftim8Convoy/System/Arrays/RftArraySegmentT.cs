namespace Rftim8Convoy.System.Arrays
{
    public class RftArraySegmentT
    {
        public RftArraySegmentT()
        {
            string[] x = ["one", "two", "three", "four"];

            ArraySegment<string> y = new(x, 1, 2);

            foreach (string item in y)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
