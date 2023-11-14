// See https://aka.ms/new-console-template for more information
using LogicLinkedList;

do
{
    Console.WriteLine("Enter number of nodes in the Linked List:");
    string? str = Console.ReadLine();
    if (!uint.TryParse(str, out uint nodesNumber))
    {
        Console.WriteLine("Wrong nodes number!");
        continue;
    }

    Node? head = LinkedListFactory.GenerateLinkedList(nodesNumber);

    uint midValue = FindMiddleElementValue(head);

    Console.WriteLine($"Total nodes number: {nodesNumber}");
    Console.WriteLine($"Mid element value: {midValue}");
    Console.WriteLine();
} while (true);


static uint FindMiddleElementValue(Node? head)
{
    uint midValue = 0;

    //TODO: Add implementation here to find a value of midle element.

    return midValue;
}