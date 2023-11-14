namespace LogicLinkedList;

public static class LinkedListFactory
{
    public static Node? GenerateLinkedList(uint nodesNumber)
    {
        Node? head = null;
        while (nodesNumber > 0)
        {
            var node = new Node(nodesNumber, next: head);
            head = node;
            nodesNumber--;
        }

        return head;
    }
}