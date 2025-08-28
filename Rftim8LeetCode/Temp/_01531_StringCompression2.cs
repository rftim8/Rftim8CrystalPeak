﻿namespace Rftim8LeetCode.Temp
{
    public class _01531_StringCompression2
    {
        /// <summary>
        /// Run-length encoding is a string compression method that works by replacing consecutive identical characters (repeated 2 or more times)
        /// with the concatenation of the character and the number marking the count of the characters (length of the run).
        /// For example, to compress the string "aabccc" we replace "aa" by "a2" and replace "ccc" by "c3". 
        /// Thus the compressed string becomes "a2bc3".
        /// 
        /// Notice that in this problem, we are not adding '1' after single characters.
        /// 
        /// Given a string s and an integer k.
        /// You need to delete at most k characters from s such that the run-length encoded version of s has minimum length.
        /// 
        /// Find the minimum length of the run-length encoded version of s after deleting at most k characters.
        /// </summary>
        public _01531_StringCompression2()
        {
            Console.WriteLine(GetLengthOfOptimalCompression0("aaabcccd", 2));
            Console.WriteLine(GetLengthOfOptimalCompression0("aabbaa", 2));
            Console.WriteLine(GetLengthOfOptimalCompression0("aaaaaaaaaaa", 0));
        }

        public static int GetLengthOfOptimalCompression0(string a0, int a1) => RftGetLengthOfOptimalCompression0(a0, a1);

        private static int RftGetLengthOfOptimalCompression0(string s, int k)
        {
            int n = s.Length;
            int[,] dp = new int[110, 110];

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    dp[i, j] = 9999;
                }
            }
            dp[0, 0] = 0;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j <= k; j++)
                {
                    int cnt = 0, del = 0;

                    for (int l = i; l >= 1; l--)
                    {
                        if (s[l - 1] == s[i - 1]) cnt++;
                        else del++;

                        if (j - del >= 0)
                        {
                            int len = cnt >= 100 ? 3 : cnt >= 10 ? 2 : cnt >= 2 ? 1 : 0;
                            dp[i, j] = Math.Min(dp[i, j], dp[l - 1, j - del] + 1 + len);
                        }
                    }

                    if (j > 0) dp[i, j] = Math.Min(dp[i, j], dp[i - 1, j - 1]);
                }
            }

            return dp[n, k];
        }
    }
}
