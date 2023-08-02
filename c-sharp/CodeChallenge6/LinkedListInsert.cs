using System.Text;
using CodeChallenges;

namespace CodeChallenges
{
  // Reference CodeChallenge5
  public class InsertableLinkedList : LinkedList
  {
    // Adds a new node with the given value to the end of the list
    public void Append(int value)
    {
      Node newNode = new Node(value);
      if (Head == null)
      {
        Head = newNode;
        Tail = newNode;
      }
      else
      {
        Tail.Next = newNode;
        Tail = newNode;
      }
    }

    // Adds a new node with the given new value immediately before the first node that has the value specified
    public void InsertBefore(int valueToInsertBefore, int value)
    {
      Node newNode = new Node(value);
      if (Head == null)
      {
        Head = newNode;
        Tail = newNode;
      }
      else if (Head.Value == valueToInsertBefore)
      {
        newNode.Next = Head;
        Head = newNode;
      }
      else
      {
        Node current = Head;
        while (current.Next != null && current.Next.Value != valueToInsertBefore)
        {
          current = current.Next;
        }
        if (current.Next != null)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
        }
      }
    }

    // Adds a new node with the given new value immediately after the first node that has the value specified
    public void InsertAfter(int valueToInsertAfter, int value)
    {
      Node newNode = new Node(value);
      if (Head == null)
      {
        Head = newNode;
        Tail = newNode;
      }
      else
      {
        Node current = Head;
        while (current != null && current.Value != valueToInsertAfter)
        {
          current = current.Next;
        }
        if (current != null)
        {
          newNode.Next = current.Next;
          current.Next = newNode;
          if (current == Tail)
          {
            Tail = newNode;
          }
        }
      }
    }
  }
}
