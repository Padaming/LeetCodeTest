public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution_24SwapNode
{
    public ListNode SwapPairs(ListNode head)
    {
        ListNode current = head;
        ListNode prev = null;
        ListNode temp;

        if (head == null)
            return null;
        if (head.next == null)
            return head;

        head = head.next;

        while(current != null && current.next != null)
        {
            temp = current.next.next;
            current.next.next = current;

            if (prev != null)
                prev.next = current.next;

            current.next = temp;

            prev = current;
            current = current.next;
        }

        return head;
    }

    public void TestCase(ListNode head)
    {
        ListNode current = head;
        Console.WriteLine("Original list");
        while(current != null)
        {
            Console.Write($"{current.val}->");
            current = current.next;
        }
        Console.WriteLine("[ ]");

        ListNode result = SwapPairs(head);
        Console.WriteLine("After swap");
        current = result;
        while (current != null)
        {
            Console.Write($"{current.val}->");
            current = current.next;
        }
        Console.WriteLine("[ ]");
    }

    public void Test()
    {
        ListNode d = new ListNode { val = 4, next = null };
        ListNode c = new ListNode { val = 3, next = d };
        ListNode b = new ListNode { val = 2, next = c };
        ListNode a = new ListNode { val = 1, next = b };

        TestCase(a);
    }
}