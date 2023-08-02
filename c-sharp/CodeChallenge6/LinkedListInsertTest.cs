using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge6Test
  {

    [Fact]
    public void InsertableLinkedList_Can_Append_New_Value()
    {
        InsertableLinkedList list = new InsertableLinkedList();

        MethodInfo appendMethod = typeof(InsertableLinkedList).GetMethod("Append");
        Assert.NotNull(appendMethod);

        int valueToInsert = 10;

        appendMethod.Invoke(list, new object[] { valueToInsert });
        PropertyInfo head = typeof(LinkedList).GetProperty("Head");

        Node headValue = (Node)head.GetValue(list);
        PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");
        int result = (int)ValueProperty.GetValue(headValue);
        Assert.Equal(valueToInsert, result);
    }

  }
}
