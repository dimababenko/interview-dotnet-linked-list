// See https://aka.ms/new-console-template for more information
using LogicLinkedList;

do
{
    Console.WriteLine("Enter number of nodes in the Linked List:");
    string? str = Console.ReadLine();
    if (!uint.TryParse(str, out uint nodesNumber))
    {
        Console.WriteLine("Wrond nodes number!");
        continue;
    }

    var linkedList = new CustomLinkedList(3);
    int midValue = 0;

    //TODO: Write a function to find a mid element.
    //midValue = FindMidValue(linkedList);

    Console.WriteLine($"Total nodes number: {nodesNumber}");
    Console.WriteLine($"Mid element value: {midValue}");
} while (true);