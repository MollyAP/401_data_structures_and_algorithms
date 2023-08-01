using CodeChallenges;
using Xunit;

namespace CodeChallengeTests
{
  public class CodeChallenge2Test
  {
    [Fact]
    public void InsertShiftArray_With_OddNumber_Of_Elements()
    {
      int[] inputArray = { 1, 2, 3, 4, 5, 6, 7 };
      int inputValue = 9;
      int[] expectedArray = { 1, 2, 3, 9, 4, 5, 6, 7 };

      int[] result = CodeChallenge2.InsertShiftArray(inputArray, inputValue);

      Assert.Equal(result, expectedArray);
    }
    [Fact]
    public void InsertShiftArray_With_EvenNumber_Of_Elements()
    {
      // Arrange
      int[] inputArray = { 1, 2, 3, 4, 5, 6 };
      int inputValue = 7;
      int[] expectedArray = { 1, 2, 3, 7, 4, 5, 6 };

      // Act
      int[] result = CodeChallenge2.InsertShiftArray(inputArray, inputValue);

      // Assert
      Assert.Equal(expectedArray, result);
    }

    [Fact]
    public void InsertShiftArray_With_EmptyArray()
    {
      // Arrange
      int[] inputArray = new int[0];
      int inputValue = 1;
      int[] expectedArray = { 1 };

      // Act
      int[] result = CodeChallenge2.InsertShiftArray(inputArray, inputValue);

      // Assert
      Assert.Equal(expectedArray, result);
    }


    [Fact]
    public void InsertShiftArray_With_NegativeNumbers()
    {
      // Arrange
      int[] inputArray = { -3, -2, -1, 0, 1 };
      int inputValue = -4;
      int[] expectedArray = { -3, -2, -4, -1, 0, 1 };

      // Act
      int[] result = CodeChallenge2.InsertShiftArray(inputArray, inputValue);

      // Assert
      Assert.Equal(expectedArray, result);
    }
  }
}
