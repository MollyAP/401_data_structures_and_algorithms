using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge4Test
  {

    public void RowSums_Test()
    {
      int[][] inputMatrix = {
        new int[] {1, 5, -3},
        new int[] {-1, 2, 8},
        new int[] {3, 2, -4}
      };

      int[] expectedResult = { 3, 9, 1 };

      int[] result = CodeChallenge4.RowSums(inputMatrix);
      Assert.Equal(result, expectedResult);
    }

    [Fact]
    public void RowSums_Test_EmptyMatrix()
    {
      // Arrange
      int[][] inputMatrix = new int[0][];
      int[] expectedResult = new int[0];

      // Act
      int[] result = CodeChallenge4.RowSums(inputMatrix);

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RowSums_Test_SingleRowMatrix()
    {
      // Arrange
      int[][] inputMatrix = { new int[] { 1, 2, 3 } };
      int[] expectedResult = { 6 };

      // Act
      int[] result = CodeChallenge4.RowSums(inputMatrix);

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RowSums_Test_SingleColumnMatrix()
    {
      // Arrange
      int[][] inputMatrix = {
        new int[] { 1 },
        new int[] { 2 },
        new int[] { 3 }
    };
      int[] expectedResult = { 1, 2, 3 };

      // Act
      int[] result = CodeChallenge4.RowSums(inputMatrix);

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RowSums_Test_NegativeNumbers()
    {
      // Arrange
      int[][] inputMatrix = {
        new int[] { -1, -2 },
        new int[] { -3, -4 },
        new int[] { -5, -6 }
    };
      int[] expectedResult = { -3, -7, -11 };

      // Act
      int[] result = CodeChallenge4.RowSums(inputMatrix);

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void RowSums_Test_MixedPositiveNegativeNumbers()
    {
      // Arrange
      int[][] inputMatrix = {
        new int[] { -1, 2, -3 },
        new int[] { 4, -5, 6 },
        new int[] { -7, 8, -9 }
    };
      int[] expectedResult = { -2, 5, -8 };

      // Act
      int[] result = CodeChallenge4.RowSums(inputMatrix);

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Fibonacci_Can_Get_5th_Number()
    {
      // Arrange
      int nth = 5;
      int expectedResult = 3;
      // Act
      int result = CodeChallenge4.GetNthNumberInFibonacciSequence(nth);

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Fibonacci_Can_Get_10th_Number()
    {
      // Arrange
      int nth = 10;
      int expectedResult = 34;
      // Act
      int result = CodeChallenge4.GetNthNumberInFibonacciSequence(nth);

      // Assert
      Assert.Equal(expectedResult, result);
    }

    [Fact]
    public void Fibonacci_Can_Get_First_Number()
    {
      // Arrange
      int nth = 1;
      int expectedResult = 0;
      // Act
      int result = CodeChallenge4.GetNthNumberInFibonacciSequence(nth);

      // Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
