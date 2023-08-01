using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge8Test
  {
    [Fact]
    public void LinkedList_ZipLists_Both_Lists_Same_Length()
    {
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedListKth list1 = new LinkedListKth();
      insertMethod.Invoke(list1, new object[] { 3 });
      insertMethod.Invoke(list1, new object[] { 2 });
      insertMethod.Invoke(list1, new object[] { 1 });



      LinkedListKth list2 = new LinkedListKth();
      insertMethod.Invoke(list2, new object[] { 30 });
      insertMethod.Invoke(list2, new object[] { 20 });
      insertMethod.Invoke(list2, new object[] { 10 });

      LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);
      MethodInfo kthFromEndMethod = typeof(LinkedListKth).GetMethod("KthFromEnd");

      Assert.Equal(1, kthFromEndMethod.Invoke(result, new object[] { 6 })); // First node from the end
      Assert.Equal(10, kthFromEndMethod.Invoke(result, new object[] { 5 })); // Second node from the end
      Assert.Equal(2, kthFromEndMethod.Invoke(result, new object[] { 4 })); // Third node from the end
      Assert.Equal(20, kthFromEndMethod.Invoke(result, new object[] { 3 })); // Fourth node from the end
      Assert.Equal(3, kthFromEndMethod.Invoke(result, new object[] { 2 })); // Fifth node from the end
      Assert.Equal(30, kthFromEndMethod.Invoke(result, new object[] { 1 })); // Sixth node from the end
    }

    [Fact]
    public void LinkedList_ZipLists_First_List_Longer()
    {
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list1 = new LinkedListKth();
      insertMethod.Invoke(list1, new object[] { 4 });
      insertMethod.Invoke(list1, new object[] { 3 });
      insertMethod.Invoke(list1, new object[] { 2 });
      insertMethod.Invoke(list1, new object[] { 1 });

      LinkedListKth list2 = new LinkedListKth();
      insertMethod.Invoke(list2, new object[] { 20 });
      insertMethod.Invoke(list2, new object[] { 10 });

      LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);
      MethodInfo kthFromEndMethod = typeof(LinkedListKth).GetMethod("KthFromEnd");

      Assert.Equal(1, kthFromEndMethod.Invoke(result, new object[] { 6 })); // First node from the end
      Assert.Equal(10, kthFromEndMethod.Invoke(result, new object[] { 5 })); // Second node from the end
      Assert.Equal(2, kthFromEndMethod.Invoke(result, new object[] { 4 })); // Third node from the end
      Assert.Equal(20, kthFromEndMethod.Invoke(result, new object[] { 3 })); // Fourth node from the end
      Assert.Equal(3, kthFromEndMethod.Invoke(result, new object[] { 2 })); // Fifth node from the end
      Assert.Equal(4, kthFromEndMethod.Invoke(result, new object[] { 1 })); // Sixth node from the end
    }


    [Fact]
    public void LinkedList_ZipLists_Second_List_Longer()
    {
      LinkedListKth list1 = new LinkedListKth();
      list1.Insert(2);
      list1.Insert(1);

      LinkedListKth list2 = new LinkedListKth();
      list2.Insert(40);
      list2.Insert(30);
      list2.Insert(20);
      list2.Insert(10);

      LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);

      Assert.Equal(1, result.KthFromEnd(6));
      Assert.Equal(10, result.KthFromEnd(5));
      Assert.Equal(2, result.KthFromEnd(4));
      Assert.Equal(20, result.KthFromEnd(3));
      Assert.Equal(30, result.KthFromEnd(2));
      Assert.Equal(40, result.KthFromEnd(1));
    }

    [Fact]
    public void LinkedList_ZipLists_One_List_Empty()
    {
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list1 = new LinkedListKth();
      insertMethod.Invoke(list1, new object[] { 2 });
      insertMethod.Invoke(list1, new object[] { 1 });

      LinkedListKth list2 = new LinkedListKth();

      LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);
      MethodInfo kthFromEndMethod = typeof(LinkedListKth).GetMethod("KthFromEnd");

      Assert.Equal(1, kthFromEndMethod.Invoke(result, new object[] { 2 })); // First node from the end
      Assert.Equal(2, kthFromEndMethod.Invoke(result, new object[] { 1 })); // Second node from the end
    }

    [Fact]
    public void LinkedList_ZipLists_Both_Lists_Empty()
    {
      MethodInfo insertMethod = typeof(LinkedListKth).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedListKth list1 = new LinkedListKth();
      LinkedListKth list2 = new LinkedListKth();

      LinkedListKth result = CodeChallenge8.ZipLists(list1, list2);
      MethodInfo kthFromEndMethod = typeof(LinkedListKth).GetMethod("KthFromEnd");

      PropertyInfo headProperty = typeof(LinkedListKth).GetProperty("Head");
      Node resultHeadNode = (Node)headProperty.GetValue(result);

      Assert.Null(resultHeadNode);
    }
  }
}