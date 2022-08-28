namespace BinaryTreeAlgorithms.Core;

/// <summary>
/// Write a function, TreeSum, that takes in the root of a binary tree that contains number values.
/// The function should return the total sum of all values in the tree.
/// </summary>
public class TreeSum
{
    /// <summary>
    /// n = number of nodes
    /// Time: O(n)
    /// Space O(n)
    /// </summary>
    public long TreeSumDepthFirstRecursive(Node<int>? root)
    {
        if (root == null)
        {
            return 0;
        }

        return root.Value + TreeSumDepthFirstRecursive(root.Left) + TreeSumDepthFirstRecursive(root.Right);
    }

    /// <summary>
    /// n = number of nodes
    /// Time: O(n)
    /// Space O(n)
    /// </summary>
    public long TreeSumBreadthFirst(Node<int>? root)
    {
        var sum = 0;

        if (root == null)
        {
            return sum;
        }

        var queue = new Queue<Node<int>>();
        queue.Enqueue(root);

        while (queue.Any())
        {
            var current = queue.Dequeue();
            sum += current.Value;

            if (current.HasLeft)
            {
                queue.Enqueue(current.Left!);
            }

            if (current.HasRight)
            {
                queue.Enqueue(current.Right!);
            }

        }
            
        return sum;
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