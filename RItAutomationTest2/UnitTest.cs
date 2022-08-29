using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RItAutomationTest2
{
    [TestClass]
    public class UnitTest
    {
        public void DepthSearchPrintTestWithZeroElements()
        {
            var tree = new BinaryTree<int>();

            var output = tree.DepthSearchPrint();

            var expected = Enumerable.Empty<int>();

            return output.SequenceEqual(expected);
        }

        public void DepthSearchPrintTestWithOneElement()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);

            var output = tree.DepthSearchPrint();

            var expected = new int[] { 1 };

            return output.SequenceEqual(expected);
        }

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

            return output.SequenceEqual(expected);
        }

        public void BreadthPrintTestWithZeroElements()
        {
            var tree = new BinaryTree<int>();

            var output = tree.BreadthSearchPrint();

            var expected = Enumerable.Empty<int>();

            return output.SequenceEqual(expected);
        }

        public void BreadthPrintTestWithOneElement()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);

            var output = tree.BreadthSearchPrint();

            var expected = new int[] { 1 };

            return output.SequenceEqual(expected);
        }

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

            return output.SequenceEqual(expected);
        }
    }
}
