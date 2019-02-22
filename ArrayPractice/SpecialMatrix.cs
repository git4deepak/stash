namespace ArrayPractice
{
using System;
using TestSupport;
public class SpecialMatrix{
    public bool IsSpecialMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        // diagonals starting at colummn 0
        for (int r = rows-1; r >= 0; --r)
        {
            if(!ScanDiagonal(matrix, rows, cols, r, 0))
            {
                return false;
            }
        }

        // diagonals starting at row 0
        for (int c = 1; c < cols; ++c)
        {
            if(!ScanDiagonal(matrix, rows, cols, 0, c))
            {
                return false;
            }
        }

        return true;
    }

    bool ScanDiagonal(int[,] matrix, int rows, int cols, int rr, int cc)
    {
            int val = matrix[rr,cc];
            ++rr;++cc;
            for (; cc< cols && rr < rows; ++cc, ++rr)
            {
                if(val >= matrix[rr,cc])
                {
                    return false;
                }
                val = matrix[rr,cc];
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