using NUnit.Framework;

namespace TDDArg.Test
{
    [TestFixture]
    public class FlattenBinaryTreeToLinkedListTest
    {
        [Test]
        public void Given_tree_When_flatten_Then_return()
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2)
            };


            FlattenBinaryTreeToLinkedList.Flatten(tree);

            Assert.AreEqual(1, tree.val);
            Assert.AreEqual(2, tree.right.val);

        }

        [Test]
        public void Given_tree_3_When_flatten_Then_return()
        {
            var tree = new TreeNode(1)
            {
                left = new TreeNode(2),
                right = new TreeNode(3)
            };


            FlattenBinaryTreeToLinkedList.Flatten(tree);

            Assert.AreEqual(1, tree.val);
            Assert.AreEqual(2, tree.right.val);
            Assert.AreEqual(3, tree.right.right.val);
        }
    }
}