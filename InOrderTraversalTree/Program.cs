// Given:
//         (4)
//        /   \
//      (1)    (6)
//     /  \      \
//   (2)  (5)    (7)

// This binary tree represents the following structure:
// * Root node: Value 4
//   * Left child of the root: Value 1
//     * Left child of node 1: Value 2
//     * Right child of node 1: Value 5
//   * Right child of the root: Value 6
//     * Left child of node 6: Value 7

// * Expected output of in-order traversal: 2, 1, 5, 4, 6, 7


#region test the solution
// 1 - Construct the tree illustrated above.
using BinarySearchInTree;

Node root = new(4);
Node leftNodeIndex0 = new(1);
Node rightNodeIndex0 = new(6);
Node leftNodeLeftIndex1 = new(2);
Node rightNodeLeftIndex1 = new(5);
Node rightNodeRightIndex1 = new(7);

root.Attach(leftNodeIndex0, Direction.Left);
root.Attach(rightNodeIndex0, Direction.Right);

leftNodeIndex0.Attach(leftNodeLeftIndex1, Direction.Left);
leftNodeIndex0.Attach(rightNodeLeftIndex1, Direction.Right);

rightNodeIndex0.Attach(rightNodeRightIndex1, Direction.Right);

// Expected output of in-order traversal: 2, 1, 5, 4, 6, 7
IReadOnlyList<int> traversedValuesInAscendingOrder = root.TraverseInAscendingOrder();
Console.WriteLine($"Traversed values in ascending order: {string.Join(", ", traversedValuesInAscendingOrder)}");

// Waiting for key to exit
Console.ReadKey();
#endregion test the solution