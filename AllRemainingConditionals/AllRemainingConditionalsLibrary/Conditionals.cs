using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AllRemainingConditionalsLibrary
{
    public class Conditionals
    {
        public int Diff21(int n)
        {
            return n > 21 ? (n - 21) * 2 : 21 - n;
        }

        public bool ParrotTrouble(bool isTalking, int hour)
        {
            return isTalking && (hour < 7 || hour > 20);
        }

        public bool Makes10(int a, int b)
        {
            return a == 10 || b == 10 || a + b == 10;
        }

        public bool NearHundred(int n)
        {
            return (n >= 90 && n <= 110) || (n >= 190 && n <= 210);
        }

        public bool PosNeg(int a, int b, bool negative)
        {
            return (!negative && a < 0 && b >= 0) || (!negative && b < 0 && a >= 0) || (negative && b < 0 && a < 0);
        }

        public string NotString(string s)
        {
            return s.StartsWith("not ") ? s : "not " + s;
        }

        public string MissingChar(string s, int n)
        {
            return s.Remove(n, 1);
        }

        public string Front3(string s)
        {
            if (s.Length > 3)
            {
                string component = s.Substring(0, 3);
                return component + component + component;
            }

            else return s + s + s;
        }

        public string BackAround(string s)
        {
            return s[s.Length - 1] + s + s[s.Length - 1];
        }

        public bool Multiple3or5(int n)
        {
            return n % 3 == 0 || n % 5 == 0;
        }

        public bool StartHi(string s)
        {
            return s.Split(' ')[0] == "hi";
        }

        public bool IcyHot(int temp1, int temp2)
        {
            return (temp1 < 0 && temp2 > 100) || (temp2 < 0 && temp1 > 100);
        }

        public bool Between10and20(int a, int b)
        {
            return (a >= 10 && a <= 20) || (b >= 10 && b <= 20);
        }

        public bool HasTeen(int a, int b, int c)
        {
            int[] parameters = new int[] { a, b, c, };
            return parameters.Any(i => (i >= 13 && i <= 19));
        }

        public bool SoAlone(int a, int b)
        {
            return ((a >= 13 && a <= 19) && !(b >= 13 && b <= 19)) || ((b >= 13 && b <= 19) && !(a >= 13 && a <= 19));
        }

    }
}
