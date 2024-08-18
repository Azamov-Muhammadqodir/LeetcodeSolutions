namespace Leetcode
{
    public class _5_Longest_Palindromic_Substring
    {
        public string LongestPalindrome_v1(string s)
        {
            try
            {
                if (s.Length == 1) return s;
                string maxWord = "";
                int FirstIndeks = 0;

                string temp = new string(s.Reverse().ToArray());
                if (temp.Equals(s)) return s;

                for (int i = 0; i < s.Length; i++)
                {
                    FirstIndeks = s.IndexOf(s[i], FirstIndeks + 1);

                    if (FirstIndeks >= 0)
                    {
                        string helper = s.Substring(i, FirstIndeks - i + 1);

                        string str = new string(helper.Reverse().ToArray());
                        if (helper.Equals(str) && helper.Length > maxWord.Length)
                            maxWord = helper;
                        i--;
                    }
                    else
                        FirstIndeks = i;

                }

                return maxWord == "" ? s[0].ToString() : maxWord;
            }
            catch (Exception)
            {

                throw ;
            }
            
        }

        public string LongestPalindrome_v3(string s)
        {
            if(string.IsNullOrWhiteSpace(s)) return s;
            int firstIndeks = 0;
            int maxLength = 1;

            for (int i = 0; i < s.Length - 1; i++)
            {
                int left = i - 1, right = i + 1;
                int tempLength = 0;
                if (i > 0 && (s[i] != s[i + 1] || s[i-1] == s[i+1]))
                {
                    while (left >= 0 && right < s.Length && s[left] == s[right])
                    {
                        left--;
                        right++;
                    }
                    tempLength = right - left - 1;
                    if (tempLength > maxLength)
                    {
                        firstIndeks = left + 1;
                        maxLength = tempLength;
                    }
                }
                if(s[i] == s[i + 1])
                {
                    left = i;
                    right = i + 1;
                    while (left >= 0 && right < s.Length && s[left] == s[right])
                    {
                        left--;
                        right++;
                    }
                    tempLength = right - left - 1;
                    if (tempLength > maxLength)
                    {
                        firstIndeks = left + 1;
                        maxLength = tempLength;
                    }
                }
            }

            return s.Substring(firstIndeks, maxLength);

        }

        public string LongestPalindrome_v2(string s)
        {
            int firstIndeks = 0;
            int maxLength = 1;

            for (int i = 0; i < s.Length; i++) 
            {
                int left = i - 1;
                int right = i + 1;
                while(left >=0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                }
                int tempLength = right - left-1;
                if(tempLength > maxLength)
                {
                    firstIndeks = left + 1;
                    maxLength = tempLength;
                }

                left = i;
                right = i + 1;
                while (left >= 0 && right < s.Length && s[left] == s[right])
                {
                    left--;
                    right++;
                }
                tempLength = right - left - 1;
                if (tempLength > maxLength)
                {
                    firstIndeks = left + 1;
                    maxLength = tempLength;
                }


            }

            return s.Substring(firstIndeks, maxLength);

        }
    }
}
