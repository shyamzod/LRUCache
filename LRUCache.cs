public class LRUCache
{
    DoublyLinkedList list = new DoublyLinkedList();
    DoublyListNode head;
    DoublyListNode tail;

    DoublyListNode pointer;
    public LRUCache()
    {
        head = list.CreateDoublyLinkedList(new List<int> { -1, -1 });
        tail = head.next;
        pointer = head;
    }
    public void AddTask(int val)
    {
        DoublyListNode newTask = new DoublyListNode(val);
        newTask.prev = pointer;
        pointer.next = newTask;
        pointer = pointer.next;
    }
    public List<int> ListOfTasks()
    {
        DoublyListNode curr = head.next;
        List<int> result = new List<int>();
        while (curr != null)
        {
            result.Add(curr.val);
            curr = curr.next;
        }
        return result;
    }
    public DoublyListNode get(int val)
    {
        DoublyListNode curr = head.next;
        DoublyListNode prev = null;
        while (curr != null)
        {
            if (curr.val == val)
            {
                prev.next = curr.next;
                curr.next.prev = prev;
                AddTask(curr.val);
                return curr;
            }
            prev = curr;
            curr = curr.next;
        }
        return null;
    }
    public static void Main(string[] args)
    {
        LRUCache lru = new LRUCache();
        lru.AddTask(1);
        lru.AddTask(2);
        lru.AddTask(3);
        Console.WriteLine("Tasks opened");
        List<int> task = lru.ListOfTasks();
        foreach (int item in task)
        {
            Console.Write(item + "  ");
        }
        Console.WriteLine();
        Console.WriteLine("Get Node");
        DoublyListNode node = lru.get(2);
        Console.WriteLine(node.val + "  ");
        Console.WriteLine("Modified Tasks");
        List<int> tasks = lru.ListOfTasks();
        foreach (int item in tasks)
        {
            Console.Write(item + "  ");
        }
    }
}