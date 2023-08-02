using System;

namespace CodeChallenges
{
  public class LinkedListKth : InsertableLinkedList
  {
    public int KthFromEnd(int kthFromEnd)
    {
      if (kthFromEnd < 0)
      {
        throw new ArgumentException("Must be positive.");
      }

      Node fast = base.Head; // Use the 'base' keyword to access the Head property
      Node slow = base.Head; // Use the 'base' keyword to access the Head property

      // Move 'fast' k nodes ahead of 'slow'
      for (int i = 0; i < kthFromEnd; i++)
      {
        if (fast == null)
        {
          // The linked list doesn't have enough nodes
          throw new ArgumentException("The linked list doesn't have enough nodes.");
        }
        fast = fast.Next;
      }

      // Move both 'fast' and 'slow' until 'fast' reaches the end
      while (fast.Next != null)
      {
        fast = fast.Next;
        slow = slow.Next;
      }

      return slow.Value;
    }
  }
}
