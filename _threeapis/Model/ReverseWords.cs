using System;
namespace _threeapis
{
    public static class ReverseWords
    {
        public static String get(String origin)
        {
            if (origin == null)
            {
                return "";
            }
            else
            {
                char[] tmp = origin.ToCharArray();
                Array.Reverse(tmp);
                return new String(tmp);
            }
        }
    }
}
