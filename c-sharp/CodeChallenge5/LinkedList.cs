using System.Text;

namespace CodeChallenges
{
  public class LinkedList
  {
    public Node Head { get; set; }

    public LinkedList()
    {
      Head = null;

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
}
