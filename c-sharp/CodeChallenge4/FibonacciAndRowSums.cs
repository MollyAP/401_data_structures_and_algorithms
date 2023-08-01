namespace CodeChallenges
{
  public class CodeChallenge4
  {
    public static int GetNthNumberInFibonacciSequence(int nthNumberInSequence)
    {
      if (nthNumberInSequence <= 0)
        return 0;

      if (nthNumberInSequence == 1 || nthNumberInSequence == 2)
        return 1;

      int prev = 1;
      int current = 1;

      for (int i = 3; i <= nthNumberInSequence; i++)
      {
        int next = prev + current;
        prev = current;
        current = next;
      }

      return current;
    }


    public static int[] RowSums(int[][] matrix)
    {
      if (matrix.Length == 0)
        return new int[0];

      int rows = matrix.Length;
      int cols = matrix[0].Length;
      int[] rowSums = new int[rows];

      for (int i = 0; i < rows; i++)
      {
        int sum = 0;
        for (int j = 0; j < cols; j++)
        {
          sum += matrix[i][j];
        }
        rowSums[i] = sum;
      }

      return rowSums;
    }
  }
}
