using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge7Test
  {

    [Fact]
    public void InsertableLinkedList_Returns_Correct_Kth_Node_From_End()
    {
      // Create an instance of the InsertableLinkedList
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list = new LinkedListKth();
      insertMethod.Invoke(list, new object[] { 10 });
      insertMethod.Invoke(list, new object[] { 20 });
      insertMethod.Invoke(list, new object[] { 30 });
      insertMethod.Invoke(list, new object[] { 40 });
      insertMethod.Invoke(list, new object[] { 50 });


      // Call the KthFromEnd method with k = 2 (getting the 2nd node from the end)
      MethodInfo kthFromEndMethod = typeof(LinkedListKth).GetMethod("KthFromEnd");
      Assert.NotNull(kthFromEndMethod);

      int k = 2;
      int kthValue = (int)kthFromEndMethod.Invoke(list, new object[] { k });

      int result = kthValue;

      // The expected value of the kth node from the end is 30
      Assert.Equal(20, result);
    }

    [Fact]
    public void InsertableLinkedList_Throws_Error_When_Kth_Is_Too_Large()
    {
      // Create an instance of the InsertableLinkedList
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list = new LinkedListKth();
      insertMethod.Invoke(list, new object[] { 10 });
      insertMethod.Invoke(list, new object[] { 20 });


      // Call the KthFromEnd method with k = 2 (getting the 2nd node from the end)
      MethodInfo kthFromEndMethod = typeof(LinkedListKth).GetMethod("KthFromEnd");
      Assert.NotNull(kthFromEndMethod);

      int k = 100;

      // The expected value of the kth node from the end is 30
      Assert.Throws<TargetInvocationException>(() => (int)kthFromEndMethod.Invoke(list, new object[] { k }));
    }

    [Fact]
    public void InsertableLinkedList_Throws_Error_When_Kth_Is_Too_Small()
    {
      // Create an instance of the InsertableLinkedList
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list = new LinkedListKth();
      insertMethod.Invoke(list, new object[] { 10 });
      insertMethod.Invoke(list, new object[] { 20 });


      // Call the KthFromEnd method with k = 2 (getting the 2nd node from the end)
      MethodInfo kthFromEndMethod = typeof(LinkedListKth).GetMethod("KthFromEnd");
      Assert.NotNull(kthFromEndMethod);

      int k = -1;

      // The expected value of the kth node from the end is 30
      Assert.Throws<TargetInvocationException>(() => (int)kthFromEndMethod.Invoke(list, new object[] { k }));
    }
  }
}