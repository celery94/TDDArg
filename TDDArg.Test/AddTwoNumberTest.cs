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

            Assert.AreEqual(3, result.val);
        }

        [Test]
        public void AddTwoNumber_TwoNode()
        {
            ListNode l1 = new ListNode(1);
            l1.next = new ListNode(2);

            ListNode l2 = new ListNode(2);
            l2.next = new ListNode(3);

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(3, result.val);
            Assert.AreEqual(5, result.next.val);
        }

        [Test]
        public void AddTwoNumber_ThreeNode()
        {
            ListNode l1 = new ListNode(1) { next = new ListNode(2) { next = new ListNode(5) } };

            ListNode l2 = new ListNode(2) { next = new ListNode(3) { next = new ListNode(4) } };

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(3, result.val);
            Assert.AreEqual(5, result.next.val);
            Assert.AreEqual(9, result.next.next.val);
        }

        [Test]
        public void AddTwoNumber_ThreeNode_Bigger_Than_10()
        {
            ListNode l1 = new ListNode(2) { next = new ListNode(4) { next = new ListNode(3) } };

            ListNode l2 = new ListNode(5) { next = new ListNode(6) { next = new ListNode(4) } };

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(7, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(8, result.next.next.val);
        }

        [Test]
        public void AddTwoNumber_Bigger_Than_10()
        {
            ListNode l1 = new ListNode(5) { };

            ListNode l2 = new ListNode(5) { };

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(0, result.val);
            Assert.AreEqual(1, result.next.val);
        }

        [Test]
        public void AddTwoNumber_Bigger_Than_10_Twice()
        {
            ListNode l1 = new ListNode(1) { };

            ListNode l2 = new ListNode(9) { next = new ListNode(9) };

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(0, result.val);
            Assert.AreEqual(0, result.next.val);
            Assert.AreEqual(1, result.next.next.val);
        }

        [Test]
        public void AddTwoNumber_L1_L2_Length_Different()
        {
            ListNode l1 = new ListNode(5) { };

            ListNode l2 = new ListNode(5) { next = new ListNode(1) };

            var result = AddTwoNumber.AddTwoNumbers(l1, l2);

            Assert.AreEqual(0, result.val);
            Assert.AreEqual(2, result.next.val);
        }
    }
}