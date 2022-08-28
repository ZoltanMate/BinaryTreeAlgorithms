namespace BinaryTreeAlgorithms.Core;

/// <summary>
/// Write a function, BreathFirstValues, that takes in the root of a binary tree.
/// The function should return an array containing all values of the tree in breadth-first order.
/// </summary>
public class BreathFirstValues
{
    /// <summary>
    /// n = number of nodes
    /// Time: O(n)
    /// Space: O(n)
    /// </summary>
    public List<T> BreathFirstValuesAlgorithm<T>(Node<T>? root)
    {
        var result = new List<T>();
        if (root == null)
        {
            return result;
        }

        var queue = new Queue<Node<T>>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var current = queue.Dequeue();
            result.Add(current.Value);

            if (current.HasLeft)
            {
                queue.Enqueue(current.Left!);
            }

            if (current.HasRight)
            {
                queue.Enqueue(current.Right!);
            }
        }

        return result;
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