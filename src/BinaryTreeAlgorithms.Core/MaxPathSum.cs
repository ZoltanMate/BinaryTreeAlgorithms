namespace BinaryTreeAlgorithms.Core;

/// <summary>
/// Write a function, MaxPathSum, that takes in the root of a binary tree that contains number values.
/// The function should return the maximum sum of array root to leaf path within the tree.
///
/// You may assume that the input tree is non-empty.
/// </summary>
public class MaxPathSum
{
    /// <summary>
    /// n = number of nodes
    /// Time: O(n)
    /// Space O(n)
    /// </summary>
    public long MaxPathSumDepthFirstRecursive(Node<int>? root)
    {
        if (root is null)
        {
            return int.MinValue;
        }

        if (!root.HasLeft && !root.HasRight)
        {
            return root.Value;
        }

        var sumOfLeft = MaxPathSumDepthFirstRecursive(root.Left);
        var sumOfRight = MaxPathSumDepthFirstRecursive(root.Right);

        return root.Value + Math.Max(sumOfLeft, sumOfRight);
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