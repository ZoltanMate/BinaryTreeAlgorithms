namespace BinaryTreeAlgorithms.Core
{
    /// <summary>
    /// Write a function, TreeIncludes, that takes in the root of a binary tree and a target value.
    /// The function should return a boolean indicating whether or not the value is contained in the tree.
    /// </summary>
    public class TreeIncludes
    {
        /// <summary>
        /// n = number of nodes
        /// Time: O(n)
        /// Space O(n)
        /// </summary>
        public bool TreeIncludesDepthFirstRecursive<T>(Node<T>? root, T target)
        {
            if (root == null)
            {
                return false;
            }

            if (root.Value!.Equals(target))
            {
                return true;
            }

            return TreeIncludesDepthFirstRecursive(root.Left, target) || TreeIncludesDepthFirstRecursive(root.Right, target);
        }

        /// <summary>
        /// n = number of nodes
        /// Time: O(n)
        /// Space O(n)
        /// </summary>
        public bool TreeIncludesBreadthFirst<T>(Node<T>? root, T target)
        {
            if (root == null)
            {
                return false;
            }

            var queue = new Queue<Node<T>>();
            queue.Enqueue(root);

            while (queue.Any())
            {
                var current = queue.Dequeue();
                if (current.Value!.Equals(target))
                {
                    return true;
                }

                if (current.HasLeft)
                {
                    queue.Enqueue(current.Left!);
                }

                if (current.HasRight)
                {
                    queue.Enqueue(current.Right!);
                }
            }

            return false;
        }

        public Node<char> CreateTestTreeChars()
        {
            var root = new Node<char>('a');
            var b = new Node<char>('b');
            var c = new Node<char>('c');
            var d = new Node<char>('d');
            var e = new Node<char>('e');
            var f = new Node<char>('f');

            root.Left = b;
            root.Right = c;
            b.Left = d;
            b.Right = e;
            c.Right = f;

            return root;
        }
    }
}
