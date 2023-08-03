using System;
using System.Reflection;
using Xunit;
using CodeChallenges;

namespace CodeChallengeTests
{
    public class CodeChallenge10Tests
    {
        private readonly Type stackType;
        private readonly Type queueType;

        public CodeChallenge10Tests()
        {
            stackType = typeof(Stack);
            queueType = typeof(Queue);
        }

        private object InvokeMethod(object obj, string methodName, params object[] parameters)
        {
            var method = obj.GetType().GetMethod(methodName, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            if (method == null)
            {
                throw new ArgumentException($"Method '{methodName}' not found on type '{obj.GetType().Name}'.");
            }

            return method.Invoke(obj, parameters);
        }

        [Fact]
        public void TestStackPush()
        {
            dynamic stack = Activator.CreateInstance(stackType);
            int valueToPush = 42;

            InvokeMethod(stack, "Push", valueToPush);

            int topValue = (int)InvokeMethod(stack, "Peek");
            Assert.Equal(valueToPush, topValue);
        }

        [Fact]
        public void TestStackPop()
        {
            dynamic stack = Activator.CreateInstance(stackType);
            int valueToPush = 42;
            InvokeMethod(stack, "Push", valueToPush);

            int poppedValue = (int)InvokeMethod(stack, "Pop");

            Assert.Equal(valueToPush, poppedValue);
            Assert.True((bool)InvokeMethod(stack, "IsEmpty"));
        }

        [Fact]
        public void TestQueueEnqueue()
        {
            dynamic queue = Activator.CreateInstance(queueType);
            int valueToEnqueue = 42;

            InvokeMethod(queue, "Enqueue", valueToEnqueue);

            int frontValue = (int)InvokeMethod(queue, "Peek");
            Assert.Equal(valueToEnqueue, frontValue);
        }

        [Fact]
        public void TestQueueDequeue()
        {
            dynamic queue = Activator.CreateInstance(queueType);
            int valueToEnqueue = 42;
            InvokeMethod(queue, "Enqueue", valueToEnqueue);

            int dequeuedValue = (int)InvokeMethod(queue, "Dequeue");

            Assert.Equal(valueToEnqueue, dequeuedValue);
            Assert.True((bool)InvokeMethod(queue, "IsEmpty"));
        }
    }
}
