using NUnit.Framework;
using RitAutomationTestTask2;
using System.Linq;

namespace RitAutimationTest2
{
    public class Tests
    {
        [Test]
        public void DepthSearchPrintTestWithZeroElements()
        {
            var tree = new BinaryTree<int>();

            var output = tree.DepthSearchPrint();

            var expected = Enumerable.Empty<int>();

            Assert.That(output.SequenceEqual(expected));
        }

        [Test]
        public void DepthSearchPrintTestWithOneElement()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);

            var output = tree.DepthSearchPrint();

            var expected = new int[] { 1 };

            Assert.That(output.SequenceEqual(expected));
        }

        [Test]
        public void DepthSearchPrintTestWithManyElements()
        {
            var tree = new BinaryTree<int>();
            tree.Add(7);
            tree.Add(3);
            tree.Add(6);
            tree.Add(9);
            tree.Add(3);
            tree.Add(4);
            tree.Add(5);

            var output = tree.DepthSearchPrint();

            var expected = new int[] { 7, 9, 3, 6, 3, 4, 5 };

            Assert.That(output.SequenceEqual(expected));
        }

        [Test]
        public void BreadthPrintTestWithZeroElements()
        {
            var tree = new BinaryTree<int>();

            var output = tree.BreadthSearchPrint();

            var expected = Enumerable.Empty<int>();

            Assert.That(output.SequenceEqual(expected));
        }

        [Test]
        public void BreadthPrintTestWithOneElement()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);

            var output = tree.BreadthSearchPrint();

            var expected = new int[] { 1 };

            Assert.That(output.SequenceEqual(expected));
        }

        [Test]
        public void BreadthPrintTestWithManyElements()
        {
            var tree = new BinaryTree<int>();
            tree.Add(6);
            tree.Add(3);
            tree.Add(6);
            tree.Add(9);
            tree.Add(8);
            tree.Add(4);
            tree.Add(5);

            var output = tree.BreadthSearchPrint();

            var expected = new int[] { 6, 6, 3, 9, 4, 8, 5 };

            Assert.That(output.SequenceEqual(expected));
        }
    }
}