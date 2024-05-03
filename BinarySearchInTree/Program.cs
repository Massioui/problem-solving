// Binary tree

//          (63)
//       /      \
//     (17)      (75)
//     /  \      / \
//   (11) (20) (57) (100)
//                     \
//                    (149)


// 1 - Build the tree
Node root = new(63);
Node rightChild1 = new(75);
Node rightChild2 = new(20);
Node rightChild3 = new(100);
Node rightChild4 = new(149);

Node leftChild1 = new(17);
Node leftChild2 = new(11);
Node leftChild3 = new(57);

root.AttachNode(leftChild1);
leftChild1.AttachNode(leftChild2);
leftChild1.AttachNode(rightChild2);

root.AttachNode(rightChild1);
rightChild1.AttachNode(leftChild3);
rightChild1.AttachNode(rightChild3);
rightChild3.AttachNode(rightChild4);

// 2 - Assert that the node valued at 100 possesses only one right child, specifically the node valued at 149.
int searchRightChild3 = 100;
Node? node = root.SearchByValue(searchRightChild3);

// 3 - Print the assert result
Console.WriteLine(node?.ToString() ?? "No node has been found with the provided search criteria.");

// 4 - Waiting for key to exit
Console.ReadKey();