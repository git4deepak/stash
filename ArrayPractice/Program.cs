using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int [,] input1 = {{1, 2, 3, 4},
                              {1, 2, 3, 4},
                              {1, 2, 3, 4},
                              {1, 2, 3, 4},
                              {1, 2, 3, 4}};
            Console.WriteLine($"Result : {IsSpecialInput(input1)}");
        }

        static bool IsSpecialInput(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            
            // diagonals starting at colummn 0
            for (int r = rows-1; r >= 0; --r)
            {
                int c = 0;
                int r1 = r;
                int val = matrix[r1,c];
                ++r1;++c;
                for (; c < cols && r1 < rows ; ++c, ++r1)
                {
                    if(val >= matrix[r1,c])
                    {
                        return false;
                    }
                    val = matrix[r1,c];
                }
            }

            // diagonals starting at row 0
            for (int c = 1; c < cols; ++c)
            {
                int c1 = c;
                int r = 0;
                int val = matrix[r,c1];

                ++r;++c1;
                for (; c1< cols && r < rows; ++c1, ++r)
                {
                    if(val >= matrix[r,c1])
                    {
                        return false;
                    }
                    val = matrix[r,c1];
                }
            }

            return true;
        }
    }
}
