namespace LogicLinkedList;

public class CustomLinkedList
{
    public CustomLinkedList(uint nodesNumber) 
    {
        Node? head = null;
        while (nodesNumber > 0)
        {
            var node = new Node(nodesNumber, next: head);
            head = node;
            nodesNumber--;
        }

        Root = head;
    }

    public Node? Root { get; }
}