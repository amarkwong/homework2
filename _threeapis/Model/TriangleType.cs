using System;
using System.Collections.Generic;
namespace _threeapis
{
    public static class TriangleType
    {
        public static String get(int a,int b,int c) //do not accept float nubmer
        {
            Dictionary<int, String> type = new Dictionary<int, String>()
            {
                {1,"Scalene"},      // all sides are different
                {2,"Isosceles"},    // two sides are equal
                {3,"Equilateral"},   // all three sides are equal
                {4,"Acute"},         // all angles are acute
                {5,"Right"},        // one angle is right
                {6,"Obtuse"},        // one angle is right
                {7,"Obtuse and Isosceles"},
                {8,"Right and Isosceles"},
                {9,"Acute and Isosceles"},
                {10,"Acute and Scalenes"},
                {11,"Right and Scalenes"},
                {12,"Obtuse and Scalenes"}
            };
            //resort 3 lines, assign c as the longest , b as the second longest, a as the shortest
            int[] intArray = new int[3] { a, b, c };
            Array.Sort(intArray);
            a = intArray[0];
            b = intArray[1];
            c = intArray[2];

            if ((a + b >c) && ( b + c > a ) && ( a + c > b))
            {
                if (a == b)
                {
                    if (b == c)
                    {
                        return type[3];
                    }
                    else
                    {
                        if (a * a + b * b == c * c)
                        {
                            return type[8];
                        }
                        else{
                            if (a * a + b * b < c * c)
                            {
                                return type[9];

                            }
                            else
                            {
                                return type[7];
                            }
                        }
                    }

                }
                else
                {
                    if (a * a + b * b == c * c)
                    {
                        return type[11];
                    }
                    else
                    {

                        if (a * a + b * b < c * c)
                        {
                            return type[12];

                        }
                        else{
                            return type[10];

                        }
                    }
                }
            }
            else
            {
                return "This is not a triangle";
            }
        }
    }
}
