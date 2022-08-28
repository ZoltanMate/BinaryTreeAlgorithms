namespace BinaryTreeAlgorithms.Core
{
    public class Node<T>
    {
        public T Value { get; }

        public Node<T>? Right { get; set; }

        public bool HasRight => Right != null;

        public Node<T>? Left { get; set; }

        public bool HasLeft => Left != null;

        public Node(T value)
        {
            ArgumentNullException.ThrowIfNull(value, nameof(value));

            Value = value;
        }
    }
}