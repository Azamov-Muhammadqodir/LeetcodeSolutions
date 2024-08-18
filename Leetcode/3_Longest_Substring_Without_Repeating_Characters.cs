using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode
{
    public  class _3_Longest_Substring_Without_Repeating_Characters
    {
        public int LengthOfLongestSubstring(string s)
        {
            try
            {
                int[] arr = new int[255];
                int currentLeng = 0;
                int firstIndex = 0;
                int maxLength = 0;
                for (int i = 0; i < s.Length; i++)
                {
                    int n = s[i];
                    arr[n]++;
                    if (arr[n] > 1)
                    {
                        arr[n]--;
                        if (s.IndexOf(s[i], firstIndex) != i)
                        {
                            if (maxLength == 0)
                            {
                                maxLength = i;
                            }

                            if (maxLength < i - firstIndex)
                            {
                                maxLength = i - firstIndex;

                            }
                            firstIndex = s.IndexOf(s[i], firstIndex) + 1;
                        }
                        currentLeng = i - firstIndex + 1;
                    }
                    else
                    {
                        currentLeng++;
                    }
                    
                    if (maxLength < currentLeng)
                    {
                        maxLength = currentLeng;
                    }
                }
                return maxLength;
            }
            catch { return 0; }
        }
    }
}
