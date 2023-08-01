using System.Text;

namespace CodeChallenges
{
  public class Node
  {
    public int Value { get; set; }
    public Node Next { get; set; }

    public Node(int value)
    {
      Value = value;
      Next = null;
    }
  }

  public class LinkedList
  {
    public Node Head { get; set; }
    public Node Tail { get; set; }

    public LinkedList()
    {
      Head = null;
      Tail = null;
    }

    public void Insert(int value)
    {
      Node newNode = new Node(value);
      newNode.Next = Head;
      Head = newNode;
    }

    public bool Includes(int value)
    {
      Node current = Head;
      while (current != null)
      {
        if (current.Value == value)
          return true;
        current = current.Next;
      }
      return false;
    }

    public override string ToString()
    {
      if (Head == null)
        return "NULL";

      Node current = Head;
      StringBuilder result = new StringBuilder();
      while (current != null)
      {
        result.Append($"{{ {current.Value} }} -> ");
        current = current.Next;
      }
      result.Append("NULL");
      return result.ToString();
    }
  }

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
