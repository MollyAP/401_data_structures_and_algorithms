using System.Reflection;
using Xunit;
using CodeChallenges;

namespace CodeChallengeTests
{
    public class CodeChallenge11Tests
    {
        private Stack<int> GetEnqueueStack(StackQueuePsuedo pseudoQueue)
        {
            var enqueueStackField = typeof(StackQueuePsuedo).GetField("enqueueStack", BindingFlags.Instance | BindingFlags.NonPublic);
            return (Stack<int>)enqueueStackField.GetValue(pseudoQueue);
        }

        private Stack<int> GetDequeueStack(StackQueuePsuedo pseudoQueue)
        {
            var dequeueStackField = typeof(StackQueuePsuedo).GetField("dequeueStack", BindingFlags.Instance | BindingFlags.NonPublic);
            return (Stack<int>)dequeueStackField.GetValue(pseudoQueue);
        }

        [Fact]
        public void Enqueue_WhenCalled_AddsItemToThePseudoQueue()
        {
            // Arrange
            var pseudoQueue = new StackQueuePsuedo();
            var enqueueMethod = typeof(StackQueuePsuedo).GetMethod("Enqueue");
            var dequeueMethod = typeof(StackQueuePsuedo).GetMethod("Dequeue");

            // Act
            enqueueMethod.Invoke(pseudoQueue, new object[] { 1 });
            enqueueMethod.Invoke(pseudoQueue, new object[] { 2 });
            enqueueMethod.Invoke(pseudoQueue, new object[] { 3 });

            // Assert
            int firstDequeue = (int)dequeueMethod.Invoke(pseudoQueue, new object[] {});
            int secondDequeue = (int)dequeueMethod.Invoke(pseudoQueue, new object[] {});
            int thirdDequeue = (int)dequeueMethod.Invoke(pseudoQueue, new object[] {});

            Assert.Equal(1, firstDequeue);
            Assert.Equal(2, secondDequeue);
            Assert.Equal(3, thirdDequeue);
        }

        [Fact]
        public void Dequeue_EmptyQueue_ThrowsInvalidOperationException()
        {
            // Arrange
            var pseudoQueue = new StackQueuePsuedo();
            var dequeueMethod = typeof(StackQueuePsuedo).GetMethod("Dequeue");


            // Act & Assert
            Assert.Throws<TargetInvocationException>(() => (int)dequeueMethod.Invoke(pseudoQueue, new object[] {}));
        }

        [Fact]
        public void EnqueueAndDequeue_InterleavedOperations_ExpectedOrder()
        {
            // Arrange
            var pseudoQueue = new StackQueuePsuedo();
            var enqueueMethod = typeof(StackQueuePsuedo).GetMethod("Enqueue");
            var dequeueMethod = typeof(StackQueuePsuedo).GetMethod("Dequeue");
            // Act

            enqueueMethod.Invoke(pseudoQueue, new object[] { 11 });
            enqueueMethod.Invoke(pseudoQueue, new object[] { 12 });
            int firstDequeue = (int)dequeueMethod.Invoke(pseudoQueue, new object[] {});
            enqueueMethod.Invoke(pseudoQueue, new object[] { 13 });
            int secondDequeue = (int)dequeueMethod.Invoke(pseudoQueue, new object[] {});
            int thirdDequeue = (int)dequeueMethod.Invoke(pseudoQueue, new object[] {});


            // Assert
            Assert.Equal(11, firstDequeue);
            Assert.Equal(12, secondDequeue);
            Assert.Equal(13, thirdDequeue);
        }
    }
}
