using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge6Test
  {

    [Fact]
    public void InsertableLinkedList_Can_Append_New_Value_To_EmptyList()
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

    [Fact]
    public void InsertableLinkedList_Can_Append_New_Value_To_List_With_2_Nodes()
    {
      MethodInfo insertMethod = typeof(InsertableLinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);

      InsertableLinkedList list = new InsertableLinkedList();
      insertMethod.Invoke(list, new object[] { -1 });
      insertMethod.Invoke(list, new object[] { 99 });

      MethodInfo appendMethod = typeof(InsertableLinkedList).GetMethod("Append");
      Assert.NotNull(appendMethod);

      int valueToInsert = 10;
      appendMethod.Invoke(list, new object[] { valueToInsert });
      PropertyInfo head = typeof(InsertableLinkedList).GetProperty("Head");

      Node headValue = (Node)head.GetValue(list);
      PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");

      PropertyInfo NextProperty = typeof(Node).GetProperty("Next");
      Node headValue2 = (Node)NextProperty.GetValue(headValue);
      Node headValue3 = (Node)NextProperty.GetValue(headValue2);
      int result = (int)ValueProperty.GetValue(headValue3);
      Assert.Equal(valueToInsert, result);
    }

    [Fact]
    public void InsertableLinkedList_Can_InsertBefore_New_Value_To_List_With_2_Nodes()
    {
      MethodInfo insertMethod = typeof(InsertableLinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);

      InsertableLinkedList list = new InsertableLinkedList();
      insertMethod.Invoke(list, new object[] { -1 });
      insertMethod.Invoke(list, new object[] { 99 });

      MethodInfo insertBeforeMethod = typeof(InsertableLinkedList).GetMethod("InsertBefore");
      Assert.NotNull(insertBeforeMethod);

      int valueToInsert = 10;
      int valueToInsertBefore = -1;
      insertBeforeMethod.Invoke(list, new object[] {valueToInsertBefore, valueToInsert });
      PropertyInfo head = typeof(InsertableLinkedList).GetProperty("Head");

      Node headValue = (Node)head.GetValue(list);
      PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");

      PropertyInfo NextProperty = typeof(Node).GetProperty("Next");
      Node headValue2 = (Node)NextProperty.GetValue(headValue);
      Node headValue3 = (Node)NextProperty.GetValue(headValue2);
      int result = (int)ValueProperty.GetValue(headValue2);
      Assert.Equal(valueToInsert, result);
    }

    [Fact]
    public void InsertableLinkedList_Can_InsertBefore_New_Value_To_List_With_1_Node()
    {
      MethodInfo insertMethod = typeof(InsertableLinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);

      InsertableLinkedList list = new InsertableLinkedList();
      insertMethod.Invoke(list, new object[] { 99 });

      MethodInfo insertBeforeMethod = typeof(InsertableLinkedList).GetMethod("InsertBefore");
      Assert.NotNull(insertBeforeMethod);

      int valueToInsert = 10;
      int valueToInsertBefore = 99;
      insertBeforeMethod.Invoke(list, new object[] {valueToInsertBefore, valueToInsert });
      PropertyInfo head = typeof(InsertableLinkedList).GetProperty("Head");

      Node headValue = (Node)head.GetValue(list);
      PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");

      PropertyInfo NextProperty = typeof(Node).GetProperty("Next");
      Node headValue2 = (Node)NextProperty.GetValue(headValue);
      int result = (int)ValueProperty.GetValue(headValue);
      Assert.Equal(valueToInsert, result);
    }

    [Fact]
    public void InsertableLinkedList_Can_InsertAfter_New_Value_To_List_With_2_Node()
    {
      MethodInfo insertMethod = typeof(InsertableLinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);

      InsertableLinkedList list = new InsertableLinkedList();
      insertMethod.Invoke(list, new object[] { -1 });
      insertMethod.Invoke(list, new object[] { 99 });

      MethodInfo insertBeforeMethod = typeof(InsertableLinkedList).GetMethod("InsertAfter");
      Assert.NotNull(insertBeforeMethod);

      int valueToInsert = 10;
      int valueToInsertAfter = -1;
      insertBeforeMethod.Invoke(list, new object[] {valueToInsertAfter, valueToInsert });
      PropertyInfo head = typeof(InsertableLinkedList).GetProperty("Head");

      Node headValue = (Node)head.GetValue(list);
      PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");

      PropertyInfo NextProperty = typeof(Node).GetProperty("Next");
      Node headValue2 = (Node)NextProperty.GetValue(headValue);
      Node headValue3 = (Node)NextProperty.GetValue(headValue2);
      int result = (int)ValueProperty.GetValue(headValue3);
      Assert.Equal(valueToInsert, result);
    }
  }
}