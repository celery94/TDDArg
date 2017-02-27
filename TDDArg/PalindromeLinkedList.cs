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

            ListNode current = null;
            slow = slow.next;

            while (slow != null)
            {
                var next = slow.next;
                slow.next = current;
                current = slow;

                slow = next;
            }

            while (current != null)
            {
                if (current.val != head.val) return false;

                current = current.next;
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