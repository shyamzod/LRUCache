public class DoublyLinkedList
{
    public DoublyListNode CreateDoublyLinkedList(List<int> values)
    {
        DoublyListNode curr = new DoublyListNode(-1);
        DoublyListNode head = curr;
        DoublyListNode prev = null;
        foreach (int item in values)
        {
            DoublyListNode temp = new DoublyListNode(item);
            curr.next = temp;
            prev = curr;
            curr = curr.next;
            curr.prev = prev;
        }
        return head.next;
    }
}