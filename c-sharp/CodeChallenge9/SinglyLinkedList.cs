using System;
using System.Text;

namespace CodeChallenges
{
  public class CodeChallenge9
  {
    // Reverses the given linked list in place
    public static void ReverseLinkedList(LinkedList linkedList)
    {
      Node previous = null;
      Node current = linkedList.Head;

      while (current != null)
      {
        Node next = current.Next;
        current.Next = previous;
        previous = current;
        current = next;
      }

      linkedList.Head = previous;
      linkedList.Tail = current;
    }

    // Checks if the given linked list is a palindrome
    public static bool IsPalindrome(LinkedList linkedList)
    {
      // To check for a palindrome, we can reverse the linked list and compare it with the original
      // If both are the same, then the linked list is a palindrome

      LinkedList reversedList = new LinkedList();
      Node current = linkedList.Head;

      // Create a new linked list with the reversed elements
      while (current != null)
      {
        reversedList.Insert(current.Value);
        current = current.Next;
      }

      // Compare the original and reversed linked lists
      Node originalCurrent = linkedList.Head;
      Node reversedCurrent = reversedList.Head;

      while (originalCurrent != null && reversedCurrent != null)
      {
        if (originalCurrent.Value != reversedCurrent.Value)
        {
          return false;
        }

        originalCurrent = originalCurrent.Next;
        reversedCurrent = reversedCurrent.Next;
      }

      // If the lengths are not equal, the linked list is not a palindrome!
      return originalCurrent == null && reversedCurrent == null;
    }
  }
}
