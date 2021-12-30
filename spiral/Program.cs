using System.Collections.Generic;

IList<int> SpiralOrder(int[][] matrix) {
    var result = new List<int>();
    int row_s = 0;
    int row_e = matrix.Length-1;
    int col_s = 0;
    int col_e = matrix[0].Length-1;
    
    while (row_s <= row_e || col_s <= col_e)
    {
        for (int j = col_s; j <= col_e && row_s <= row_e; ++j)
            result.Add(matrix[row_s][j]);
        row_s++;
        
        for(int i = row_s; i <= row_e && col_s <= col_e; ++i)
            result.Add(matrix[i][col_e]);
        col_e--;

        for (int j = col_e; j >= col_s&& row_s <= row_e; --j)
            result.Add(matrix[row_e][j]);
        row_e--;

        for (int i = row_e; i >= row_s && col_s <= col_e; --i)
            result.Add(matrix[i][col_s]);
        col_s++;
    }
    
    return result;
}
int[][] input = new int [3][];
input[0] = new int[] {1,2,3,4};
input[1] = new int[] {5,6,7,8};
input[2] = new int [] {9,10,11,12};

SpiralOrder(input);
Console.WriteLine("Hello, World!");
