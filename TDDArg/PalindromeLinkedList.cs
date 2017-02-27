using NUnit.Framework;

namespace TDDArg
{
    [TestFixture]
    public class PalindromeLinkedList
    {
        public bool IsPalindrome(ListNode head)
        {
            if (head?.next == null) return true;

            var slow = head;
            var fast = head;

            while (fast.next != null && fast.next.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }

            ListNode pre = null;
            slow = slow.next;
            var next = slow.next;

            while (next != null)
            {
                slow.next = pre;
                pre = slow;

                slow = next;
                next = slow.next;
            }
            slow.next = pre;


            while (slow != null)
            {
                if (slow.val != head.val) return false;

                slow = slow.next;
                head = head.next;
            }

            return true;
        }

        [Test]
        public void Given_list_When_check_Then_return()
        {
            var head = new ListNode(1)
            {
                next = new ListNode(1)
                {
                    next = new ListNode(2)
                    {
                        next = new ListNode(1)
                    }
                }
            };

            Assert.IsFalse(IsPalindrome(head));
        }
    }
}