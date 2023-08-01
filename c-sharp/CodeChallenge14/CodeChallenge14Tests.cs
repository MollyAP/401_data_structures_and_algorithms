using CodeChallenges;
using Xunit;
using System.Reflection;

namespace CodeChallengeTests
{
  public class CodeChallenge14Tests
  {

    private object GetPrivateField(object instance, string fieldName)
    {
      Type type = instance.GetType();
      FieldInfo fieldInfo = type.GetField(fieldName);
      return fieldInfo.GetValue(instance);
    }

    private object InvokePrivateMethod(object instance, string methodName, params object[] parameters)
    {
      Type type = instance.GetType();
      MethodInfo methodInfo = type.GetMethod(methodName);
      return methodInfo.Invoke(instance, parameters);
    }

    [Fact]
    public void TestMaxStack()
    {
      CodeChallenge14.MaxStack maxStack = new CodeChallenge14.MaxStack();

      // Use InvokePrivateMethod to call private methods (Push, Pop, Peek, GetMax)
      InvokePrivateMethod(maxStack, "Push", 5);
      InvokePrivateMethod(maxStack, "Push", 3);
      InvokePrivateMethod(maxStack, "Push", 7);
      InvokePrivateMethod(maxStack, "Push", 2);
      InvokePrivateMethod(maxStack, "Push", 9);

      // Use GetPrivateField to get the values of private fields (stack, maxStack, and top)


      Assert.Equal(9, (int)InvokePrivateMethod(maxStack, "GetMax"));

      InvokePrivateMethod(maxStack, "Pop");
      Assert.Equal(7, (int)InvokePrivateMethod(maxStack, "GetMax"));

      InvokePrivateMethod(maxStack, "Pop");
      Assert.Equal(7, (int)InvokePrivateMethod(maxStack, "GetMax"));

      InvokePrivateMethod(maxStack, "Push", 10);
      Assert.Equal(10, (int)InvokePrivateMethod(maxStack, "GetMax"));
    }
  }
}
