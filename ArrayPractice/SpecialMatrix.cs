namespace ArrayPractice
{
using System;
using TestSupport;
public class SpecialMatrix{
    bool IsSpecialMatrix(int[,] matrix)
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

    public void Test()
    {
        int [,] input1 = {{1, 2, 3, 4},
                          {1, 2, 3, 4},
                          {1, 2, 3, 4},
                          {1, 2, 3, 4},
                          {1, 2, 3, 4}};
        Assert.IsTrue(IsSpecialMatrix(input1), "Test 1", "Expected true");

        int [,] input2 = {{1, 2, 3, 4},
                          {1, 2, 4, 4},
                          {1, 2, 3, 4},
                          {1, 2, 3, 4},
                          {1, 2, 3, 4}};
        Assert.IsTrue(!IsSpecialMatrix(input2), "Test 2", "Expected false");

        int [,] input3 = {{1, 2, 3, 4}};
        Assert.IsTrue(IsSpecialMatrix(input3), "Test 3", "Expected true");
    }
}
}