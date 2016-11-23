using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class AddTwoNumberTest
    {
        [Test]
        public void AddTwoNumber_SingleNode()
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(3, result.Val);
        }

        [Test]
        public void AddTwoNumber_TwoNode()
        {
            ListNode l1 = new ListNode(1);
            l1.Next = new ListNode(2);

            ListNode l2 = new ListNode(2);
            l2.Next = new ListNode(3);

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(3, result.Val);
            Assert.AreEqual(5, result.Next.Val);
        }

        [Test]
        public void AddTwoNumber_ThreeNode()
        {
            ListNode l1 = new ListNode(1) { Next = new ListNode(2) { Next = new ListNode(5) } };

            ListNode l2 = new ListNode(2) { Next = new ListNode(3) { Next = new ListNode(4) } };

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(3, result.Val);
            Assert.AreEqual(5, result.Next.Val);
            Assert.AreEqual(9, result.Next.Next.Val);
        }

        //[Test]
        public void AddTwoNumber_ThreeNode_Bigger_Than_10()
        {
            ListNode l1 = new ListNode(2) { Next = new ListNode(4) { Next = new ListNode(3) } };

            ListNode l2 = new ListNode(5) { Next = new ListNode(6) { Next = new ListNode(4) } };

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(7, result.Val);
            Assert.AreEqual(0, result.Next.Val);
            Assert.AreEqual(8, result.Next.Next.Val);
        }
    }
}