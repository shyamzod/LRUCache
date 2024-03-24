public class DoublyListNode
{
    public int val { get; set; }
    public DoublyListNode prev { get; set; }
    public DoublyListNode next { get; set; }
    public DoublyListNode(int val, DoublyListNode prev = null, DoublyListNode next = null)
    {
        this.val = val;
        this.prev = prev;
        this.next = next;
    }
}