using System;
using System.Collections.Generic;

namespace RitAutomationTestTask2
{
    internal class BinaryTreeNode<TValue> where TValue : IComparable
    {
        internal TValue Value { get; set; }
        internal BinaryTreeNode<TValue> Left { get; set; }
        internal BinaryTreeNode<TValue> Right { get; set; }
    }

    public class BinaryTree<TValue> where TValue : IComparable
    {
        private BinaryTreeNode<TValue> _route;

        public void Add(TValue value)
        {
            if (_route == null)
            {
                _route = new BinaryTreeNode<TValue> { Value = value };
                return;
            }

            var curNode = _route;

            while (true)
            {
                if (curNode.Value.CompareTo(value) <= 0)
                {
                    if (curNode.Right != null)
                    {
                        curNode = curNode.Right;
                        continue;
                    }
                    else
                    {
                        curNode.Right = new BinaryTreeNode<TValue> { Value = value };
                        break;
                    }
                }

                if (curNode.Value.CompareTo(value) > 0)
                {
                    if (curNode.Left != null)
                    {
                        curNode = curNode.Left;
                        continue;
                    }
                    else
                    {
                        curNode.Left = new BinaryTreeNode<TValue> { Value = value };
                        break;
                    }
                }
            }
        }

        public IEnumerable<TValue> DepthSearchPrint()
        {
            if (_route == null) yield break;

            var stack = new Stack<BinaryTreeNode<TValue>>();
            stack.Push(_route);

            while (stack.Count > 0)
            {
                var curNode = stack.Pop();

                yield return curNode.Value;

                if (curNode.Left != null) stack.Push(curNode.Left);
                if (curNode.Right != null) stack.Push(curNode.Right);
            }
        }

        public IEnumerable<TValue> BreadthSearchPrint()
        {
            if (_route == null) yield break;

            var queue = new Queue<BinaryTreeNode<TValue>>();
            queue.Enqueue(_route);

            while (queue.Count > 0)
            {
                var curNode = queue.Dequeue();

                yield return curNode.Value;

                if (curNode.Right != null) queue.Enqueue(curNode.Right);
                if (curNode.Left != null) queue.Enqueue(curNode.Left);
            }
        }
    }
}
