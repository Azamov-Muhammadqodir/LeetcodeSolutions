namespace Leetcode
{
    public class _5_Longest_Palindromic_Substring
    {
        public string LongestPalindrome(string s)
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
    }
}
