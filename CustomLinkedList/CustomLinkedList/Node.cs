namespace LogicLinkedList;

public class Node
{
    public Node(uint value, Node? next)
    {
        Value = value;
        Next = next;
    }

    public Node? Next { get; set; }

    public uint Value { get; set; }
}