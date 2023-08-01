using CodeChallenges;
using Xunit;
using System.Reflection;
namespace CodeChallengeTests
{
  public class CodeChallenge5Test
  {
    [Fact]
    public void LinkedList_Has_Head_Property()
    {
      PropertyInfo head = typeof(LinkedList).GetProperty("Head");
      Assert.NotNull(head);
    }

    [Fact]
    public void LinkedList_Head_Property_Is_Node()
    {
      PropertyInfo head = typeof(LinkedList).GetProperty("Head");
      Type headType = head.PropertyType;
      Assert.Equal(typeof(Node), headType);
    }

    [Fact]
    public void LinkedList_Can_Add_Single_Value()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedList list = new LinkedList();

      int value = 5;
      insertMethod.Invoke(list, new object[]{value});
      PropertyInfo head = typeof(LinkedList).GetProperty("Head");

      Node headValue = (Node)head.GetValue(list);

      PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");
      
      
      int result = (int)ValueProperty.GetValue(headValue);

      Assert.Equal(value, result);
    }

    [Fact]
    public void LinkedList_Can_Add_Two_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedList list = new LinkedList();
      int value = 5;
      int value2 = 6;
      insertMethod.Invoke(list, new object[]{value});
      insertMethod.Invoke(list, new object[]{value2});

      PropertyInfo head = typeof(LinkedList).GetProperty("Head");

      Type headType = head.PropertyType;
      Node headValue = (Node)head.GetValue(list);

      PropertyInfo ValueProperty = typeof(Node).GetProperty("Value");
      
      int result1 = (int)ValueProperty.GetValue(headValue);
      
      PropertyInfo NextProperty = typeof(Node).GetProperty("Next");
      Node headValue2 = (Node)NextProperty.GetValue(headValue);

      int result2 = (int)ValueProperty.GetValue(headValue2);
      Node headValue3 = (Node)NextProperty.GetValue(headValue);


      Assert.Equal(value2, result1);
      Assert.Equal(value, result2);
    }

    [Fact]
    public void Includes_Returns_True_When_Value_Is_Present()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      
      LinkedList list = new LinkedList();
      int value1 = 5;
      int value2 = 6;
      int value3 = -1;
      int value4 = -2;
      int value5 = 0;
      insertMethod.Invoke(list, new object[]{value1});
      insertMethod.Invoke(list, new object[]{value2});
      insertMethod.Invoke(list, new object[]{value3});
      insertMethod.Invoke(list, new object[]{value4});
      insertMethod.Invoke(list, new object[]{value5});

      MethodInfo includesMethod = typeof(LinkedList).GetMethod("Includes");
      Assert.True(includesMethod != null);

      bool result1 = (bool)includesMethod.Invoke(list, new object[]{value1});
      bool result2 = (bool)includesMethod.Invoke(list, new object[]{value2});
      bool result3 = (bool)includesMethod.Invoke(list, new object[]{value3});
      bool result4 = (bool)includesMethod.Invoke(list, new object[]{value4});
      bool result5 = (bool)includesMethod.Invoke(list, new object[]{value5});

      Assert.True(result1);
      Assert.True(result2);
      Assert.True(result3);
      Assert.True(result4);
      Assert.True(result5);
    }

    [Fact]
    public void Includes_Returns_False_When_Value_IsNot_Present()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      
      LinkedList list = new LinkedList();
      int value1 = 5;
      int value2 = 6;
      int value3 = -1;
      int value4 = -2;
      int value5 = 0;
      insertMethod.Invoke(list, new object[]{value1});
      insertMethod.Invoke(list, new object[]{value2});
      insertMethod.Invoke(list, new object[]{value3});
      insertMethod.Invoke(list, new object[]{value4});
      insertMethod.Invoke(list, new object[]{value5});

      MethodInfo includesMethod = typeof(LinkedList).GetMethod("Includes");
      Assert.True(includesMethod != null);

      bool result1 = (bool)includesMethod.Invoke(list, new object[]{1122});
      bool result2 = (bool)includesMethod.Invoke(list, new object[]{123213});
      bool result3 = (bool)includesMethod.Invoke(list, new object[]{555});
      bool result4 = (bool)includesMethod.Invoke(list, new object[]{666});


      Assert.False(result1);
      Assert.False(result2);
      Assert.False(result3);
      Assert.False(result4);
    }

    [Fact]
    public void ToString_Returns_Correct_String_Representation_With_Two_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);

      LinkedList list = new LinkedList();
      int value1 = 5;
      int value2 = 6;
      insertMethod.Invoke(list, new object[]{value1});
      insertMethod.Invoke(list, new object[]{value2});

      MethodInfo toStringMethod = typeof(LinkedList).GetMethod("ToString");
      Assert.True(toStringMethod != null);

      string expectedString = "6 -> 5 -> NULL";
      string result = (string)toStringMethod.Invoke(list, new object[]{});;

      Assert.Equal(expectedString, result);
    }

    [Fact]
    public void ToString_Returns_Correct_String_Representation_With_5_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      
      LinkedList list = new LinkedList();
      insertMethod.Invoke(list, new object[]{-1});
      insertMethod.Invoke(list, new object[]{99});
      insertMethod.Invoke(list, new object[]{6});
      insertMethod.Invoke(list, new object[]{12});
      insertMethod.Invoke(list, new object[]{0});

      MethodInfo toStringMethod = typeof(LinkedList).GetMethod("ToString");
      Assert.True(toStringMethod != null);

      string expectedString = "0 -> 12 -> 6 -> 99 -> -1 -> NULL";
      string result = (string)toStringMethod.Invoke(list, new object[]{});

      Assert.Equal(expectedString, result);
    }

    [Fact]
    public void ToString_Returns_Correct_String_Representation_With_0_Nodes()
    {
      MethodInfo insertMethod = typeof(LinkedList).GetMethod("Insert");
      Assert.True(insertMethod != null);
      LinkedList list = new LinkedList();

      MethodInfo toStringMethod = typeof(LinkedList).GetMethod("ToString");
      Assert.True(toStringMethod != null);

      string expectedString = "NULL";
      string result = (string)toStringMethod.Invoke(list, new object[]{});

      Assert.Equal(expectedString, result);
    }
  }
}