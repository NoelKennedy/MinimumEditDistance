using System;

namespace MinimumEditDistance {

    /// <summary>
    /// Holds the Levenshtein distance calculation method
    /// </summary>
    public static class Levenshtein {

        /// <summary>
        /// Calculates the Levenshtein minimum edit distance from one string to another
        /// </summary>
        /// <param name="s"></param>
        /// <param name="t"></param>
        /// <param name="substitutionCost">int the cost of substituting one letter for another.  Typically 1 or 2</param>
        /// <returns></returns>
        public static int CalculateDistance(string s, string t, int substitutionCost) {
            var m = s.Length;
            var n = t.Length;

            int[,] d = new int[m, n];

            //first row + column = distance from empty to other
            for (int i = 0; i < m; i++) {
                d[i, 0] = i;
            }
            for (int i = 0; i < n; i++) {
                d[0, i] = i;
            }

            for (int j = 1; j < n; j++) {
                for (int i = 1; i < m; i++) {
                    if (s[i - 1] == t[j - 1]) {
                        d[i, j] = d[i - 1, j - 1]; //no cost, letters the same
                    } else {
                        var delete = d[i - 1, j] + 1;
                        var insert = d[i, j - 1] + 1;
                        var substitute = d[i - 1, j - 1] + 1;
                        d[i, j] = Math.Min(delete, Math.Min(insert, substitute));
                    }

                }
            }

            return d[m - 1, n - 1];
        }
    }
}
