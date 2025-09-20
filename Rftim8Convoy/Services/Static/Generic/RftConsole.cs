using System.Text;

namespace Rftim8Convoy.Services.Static.Generic
{
    public class RftConsole
    {
        public static string PrintChar2DArrayToString(List<char[][]> chars)
        {
            StringBuilder sb = new();

            foreach (char[][] item in chars)
            {
                sb.AppendLine("New Board:");

                foreach (char[] item1 in item)
                {
                    foreach (char item2 in item1)
                    {
                        sb.Append($"{item2} ");
                    }

                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
}
