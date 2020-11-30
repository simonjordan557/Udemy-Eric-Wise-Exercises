using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AllLoopsLibrary
{
    public class Loops
    {
        StringBuilder sb;
        public string StringTimes(string s, int n)
        {
            if (n == 1) return s;
            if (n <= 0) return "";
            else
            {
                sb = new StringBuilder();
                for (int i = 0; i < n; i++)
                {
                    sb.Append(s);
                }

                return sb.ToString();
            }
        }

        public string FrontTimes(string s, int n)
        {
            if (n <= 0) return "";
            int counter;
            if (s.Length < 3)
            {
                counter = s.Length;
            }
            else
            {
                counter = 3;
            }
            
                sb = new StringBuilder();
                for (int i = 0; i < n; i++)
                {
                    sb.Append(s.Substring(0, counter));
                }

                return sb.ToString();
        }

        public int CountXX(string s)
        {
            int result = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if (s[i] == 'x' && s[i - 1] == 'x')
                {
                    result++;
                }
            }
            return result;
        }

        public string EveryOther(string s)
        {
            if (s.Length <= 1) return s;
            sb = new StringBuilder();
            for (int i = 0; i < s.Length; i += 2)
            {
                sb.Append(s[i]);
            }

            return sb.ToString();
        }

        public string StringSplosion(string s)
        {
            sb = new StringBuilder();
            for (int i = 1; i <= s.Length; i++)
            {
                sb.Append(s.Substring(0, i));
            }

            return sb.ToString();
        }

        public int CountLast2(string s)
        {
            int result = 0;
            string test = s.Substring(s.Length - 2, 2);
            for (int i = 0; i < s.Length - 3; i++)
            {
                if (s.Substring(i, 2) == test)
                {
                    result++;
                }
            }
            return result;
        }

        public int Count9(int[] numbers)
        {
            return numbers.Count(i => i == 9);
        }

        public bool ArrayFront9(int[] numbers)
        {
            return numbers.Take(4).Contains(9);
        }

        public bool Array123(int[] numbers)
        {
            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] == 3)
                {
                    if (numbers[i - 1] == 2)
                    {
                        if (numbers[i - 2] == 1)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public int SubStringMatch(string a, string b)
        {
            if (a.Length < 2 || b.Length < 2) return 0;

            int result = 0;
            for (int i = 0; i <= a.Length - 2; i++)
            {
                if (b.Contains(a.Substring(i, 2)))
                {
                    result++;
                }
            }

            return result;
        }

        public string StringX(string s)
        {
            string testString = s.Substring(1, s.Length - 2);
            return s[0] + testString.Replace("x", "") + s[s.Length - 1];
        }
        public string AltPairs(string s)
        {
            if (s.Length < 2) return "";

            sb = new StringBuilder();
            for (int i = 0; i < s.Length; i += 4)
            {
                sb.Append(s.Substring(i, 1));
                if (i != s.Length - 1)
                {
                    sb.Append(s.Substring(i + 1, 1));
                }
            }

            return sb.ToString();
        }

        public string DoNotYak(string s)
        {
            if (s.Length < 3) return s;

            for (int i = 0; i <= s.Length - 3; i++)
            {
                if (s.Substring(i, 3) == "yak")
                {
                    s = s.Remove(i, 3);
                }
            }
            return s;
        }

        public int Array667(int[] numbers)
        {
            int result = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == 6 || numbers[i] == 7)
                {
                    if (numbers[i - 1] == 6)
                    {
                        result++;
                    }
                }
            }
            return result;
        }

        public bool NoTriples(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 3; i++)
            {
                if (numbers[i + 1] == numbers[i])
                {
                    if (numbers[i + 2] == numbers[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool Pattern51(int[] numbers)
        {
            for (int i = 0; i <= numbers.Length - 3; i++)
            {
                if (numbers[i + 1] == numbers[i] + 5)
                {
                    if (numbers[i + 2] == numbers[i] - 1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
