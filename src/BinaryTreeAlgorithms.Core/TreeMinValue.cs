namespace BinaryTreeAlgorithms.Core;

/// <summary>
/// Write a function, TreeMinValue, that takes in the root of a binary tree that contains number values
/// The function should return the minimum value within the tree.
///
/// You may assume that the input tree is non-empty.
/// </summary>
public class TreeMinValue
{
    /// <summary>
    /// n = number of nodes
    /// Time: O(n)
    /// Space O(n)
    /// </summary>
    public int TreeMinValueDepthFirstRecursive(Node<int>? root)
    {
        if (root == null)
        {
            return int.MaxValue;
        }

        var leftMinValue = TreeMinValueDepthFirstRecursive(root.Left!);
        var rightMinValue = TreeMinValueDepthFirstRecursive(root.Right!);
            
        return Math.Min(root.Value, Math.Min(leftMinValue, rightMinValue));
    }

    /// <summary>
    /// n = number of nodes
    /// Time: O(n)
    /// Space O(n)
    /// </summary>
    public int TreeMinValueBreathFirst(Node<int> root)
    {
        var min = int.MaxValue;
        var queue = new Queue<Node<int>>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var current = queue.Dequeue();
            if (current.Value < min)
            {
                min = current.Value;
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

        return min;
    }

    public Node<int> CreateTestTreeNumbers()
    {
        var root = new Node<int>(3);
        var b = new Node<int>(11);
        var c = new Node<int>(4);
        var d = new Node<int>(4);
        var e = new Node<int>(-2);
        var f = new Node<int>(1);

        root.Left = b;
        root.Right = c;
        b.Left = d;
        b.Right = e;
        c.Right = f;

        return root;
    }
}