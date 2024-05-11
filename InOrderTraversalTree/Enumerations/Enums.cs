using System.ComponentModel;

namespace InOrderTraversalTree.Enumerations;

internal enum Direction : ushort
{
    [Description("Represents the left direction.")]
    Left = 0,
    [Description("Represents the right direction.")]
    Right = 1
}