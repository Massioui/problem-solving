using System.Diagnostics.CodeAnalysis;

namespace BinarySearchInTree;

internal sealed class Node(int value)
{
    public int Value { get; init; } = value;
    public Node? Left { get; private set; }
    public Node? Right { get; private set; }

    /// <summary>
    /// Attaches a node to either the left or right direction of the current node.
    /// </summary>
    /// <param name="node">The node to attach.</param>
    /// <param name="direction">The direction in which to attach the node.</param>
    /// <exception cref="ArgumentNullException">Thrown when the provided node is null.</exception>
    public void Attach(Node node, [NotNull] Direction direction)
    {
        if (node is null) ArgumentNullException.ThrowIfNull(nameof(node));

        if (direction == Direction.Left)
        {
            Left = node;
        }

        if (direction == Direction.Right)
        {
            Right = node;
        }
    }

    /// <summary>
    /// Performs an in-order traversal of the binary tree rooted at the current node.
    /// </summary>
    public IReadOnlyList<int> TraverseInAscendingOrder()
    {
        IList<int> values = [];

        TraverseInAscendingOrder(this, values);

        return [.. values];
    }

    private static void TraverseInAscendingOrder(Node? node, IList<int> values)
    {
        if (node is null) return;

        TraverseInAscendingOrder(node.Left, values);
        values.Add(node.Value);
        TraverseInAscendingOrder(node.Right, values);
    }
}
