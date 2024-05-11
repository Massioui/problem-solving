using System.Text;

namespace BinarySearchInTree;

internal sealed class Node(int value)
{
    public int Value { get; init; } = value;
    public Node? LeftChild { get; private set; }
    public Node? RightChild { get; private set; }

    /// <summary>
    /// Attaches a node to the current node as its child.
    /// </summary>
    /// <param name="node">The node to attach.</param>
    /// <exception cref="ArgumentNullException">Thrown when the provided node is null.</exception>
    public void AttachNode(Node node)
    {
        ArgumentNullException.ThrowIfNull(nameof(node));

        bool isDuplicate = node.Value == Value;

        if (isDuplicate) return;

        bool isRightNode = node.Value > Value;

        if (isRightNode)
        {
            RightChild = node;
        }
        else
        {
            LeftChild = node;
        }
    }

    /// <summary>
    /// Searches for a node with the specified value in the tree rooted at the current node.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns>The node with the specified value if found; otherwise, null.</returns>>
    public Node? SearchByValue(int value)
    {
        if (value == Value) return this;

        bool shouldSearchInRightChild = value > Value;

        if (shouldSearchInRightChild && RightChild is not null)
        {
            return RightChild.SearchByValue(value);
        }

        bool shouldSearchInLeftChild = value < Value;
        if (shouldSearchInLeftChild && LeftChild is not null)
        {
            return LeftChild.SearchByValue(value);
        }

        return default;
    }

    public override string ToString()
    {
        bool hasRightChild = RightChild is not null;
        bool hasLeftChild = LeftChild is not null;

        StringBuilder stringBuilder = new();
        stringBuilder.Append($"The node value is : {Value}.\n");
        stringBuilder.Append(hasRightChild ? $"The value of his right child is : {RightChild!.Value}.\n" : "This node has no right child.\n");
        stringBuilder.Append(hasLeftChild ? $"The value of his left child is : {LeftChild!.Value}.\n" : "This node has no left child.\n");

        return stringBuilder.ToString();
    }
}