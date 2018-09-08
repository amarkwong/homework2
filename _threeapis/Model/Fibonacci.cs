using System;
namespace _threeapis
{
    public static class Fibonacci
    {
        public static int get(int i)
        {
            if (i < 0 || i > 10000)
            {
                return -1;
            }
            else
            {
                switch (i)
                {
                    case 0:
                        return 0;
                    case 1:
                        return 1;
                    default:
                        return Fibonacci.get(i - 1) + Fibonacci.get(i - 2);
                }
            }
        }
    }
}