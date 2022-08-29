using System;
using System.Linq;

namespace RitAutomationTestTask2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Тесты");
            Console.WriteLine("Обход в глубину пустого дерева: " + DepthSearchPrintTestWithZeroElements());
            Console.WriteLine("Обход в глубину дерева с одним элементом: " + DepthSearchPrintTestWithZeroElements());
            Console.WriteLine("Обход дерева в глубину: " + DepthSearchPrintTestWithManyElements());
            Console.WriteLine();
            Console.WriteLine("Обход в ширину пустого дерева: " + BreadthPrintTestWithZeroElements());
            Console.WriteLine("Обход в ширину дерева с одним элементом: " + BreadthPrintTestWithOneElement());
            Console.WriteLine("Обход дерева в ширину: " + BreadthPrintTestWithManyElements());
        }

        public static bool DepthSearchPrintTestWithZeroElements()
        {
            var tree = new BinaryTree<int>();

            var output = tree.DepthSearchPrint();

            var expected = Enumerable.Empty<int>();

            return output.SequenceEqual(expected);
        }

        public static bool DepthSearchPrintTestWithOneElement()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);

            var output = tree.DepthSearchPrint();

            var expected = new int[] { 1 };

            return output.SequenceEqual(expected);
        }

        public static bool DepthSearchPrintTestWithManyElements()
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

        public static bool BreadthPrintTestWithZeroElements()
        {
            var tree = new BinaryTree<int>();

            var output = tree.BreadthSearchPrint();

            var expected = Enumerable.Empty<int>();

            return output.SequenceEqual(expected);
        }

        public static bool BreadthPrintTestWithOneElement()
        {
            var tree = new BinaryTree<int>();
            tree.Add(1);

            var output = tree.BreadthSearchPrint();

            var expected = new int[] { 1 };

            return output.SequenceEqual(expected);
        }

        public static bool BreadthPrintTestWithManyElements()
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
