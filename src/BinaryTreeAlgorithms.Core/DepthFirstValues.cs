namespace BinaryTreeAlgorithms.Core;

/// <summary>
/// Write a function, DepthFirstValues, that takes in the root of a binary tree.
/// The function should return an array containing all values of the tree in depth-first order.
/// </summary>
public class DepthFirstValues
{
    public List<T> DepthFirstValuesIterative<T>(Node<T>? root)
    {
        var result = new List<T>();

        if (root == null)
        {
            return result;
        }

        var stack = new Stack<Node<T>>();
        stack.Push(root);

        while (stack.Any())
        {
            var current = stack.Pop();
            result.Add(current.Value);

            if (current.HasRight)
            {
                stack.Push(current.Right!);
            }

            if (current.HasLeft)
            {
                stack.Push(current.Left!);
            }
        }
            
        return result;
    }

    public List<T> DepthFirstValuesRecursive<T>(Node<T>? root)
    {
        var result = new List<T>();

        if (root == null)
        {
            return result;
        }

        var leftValues = DepthFirstValuesRecursive(root.Left);
        var rightValues = DepthFirstValuesRecursive(root.Right);

        result.Add(root.Value);
        result.AddRange(leftValues);
        result.AddRange(rightValues);

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
        d.Right = e;
        c.Right = f;

        return root;
    }

    public Node<int> CreateTestTreeNumbers()
    {
        var root = new Node<int>(1);
        var two = new Node<int>(2);
        var three = new Node<int>(3);
        var four = new Node<int>(4);
        var five = new Node<int>(5);
        var six = new Node<int>(6);

        root.Left = two;
        root.Right = three;
        two.Left = four;
        four.Right = five;
        three.Right = six;

        return root;
    }
}