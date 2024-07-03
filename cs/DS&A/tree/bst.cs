using System;

class BinarySearchTree<T> where T : IComparable<T>
{
    private class TreeNode
    {
        public T Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(T value)
        {
            Value = value;
            Left = Right = null;
        }
    }

    private TreeNode root;

    public void Add(T value)
    {
        root = AddRecursive(root, value);
    }

    private TreeNode AddRecursive(TreeNode node, T value)
    {
        if (node == null)
        {
            return new TreeNode(value);
        }

        if (value.CompareTo(node.Value) < 0)
        {
            node.Left = AddRecursive(node.Left, value);
        }
        else if (value.CompareTo(node.Value) > 0)
        {
            node.Right = AddRecursive(node.Right, value);
        }

        return node;
    }

    public void PreorderTraversal()
    {
        PreorderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void PreorderTraversalRecursive(TreeNode node)
    {
        if (node != null)
        {
            Console.Write(node.Value + " ");
            PreorderTraversalRecursive(node.Left);
            PreorderTraversalRecursive(node.Right);
        }
    }

    public void InorderTraversal()
    {
        InorderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void InorderTraversalRecursive(TreeNode node)
    {
        if (node != null)
        {
            InorderTraversalRecursive(node.Left);
            Console.Write(node.Value + " ");
            InorderTraversalRecursive(node.Right);
        }
    }

    public void PostorderTraversal()
    {
        PostorderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void PostorderTraversalRecursive(TreeNode node)
    {
        if (node != null)
        {
            PostorderTraversalRecursive(node.Left);
            PostorderTraversalRecursive(node.Right);
            Console.Write(node.Value + " ");
        }
    }

    public bool Find(T value)
    {
        return FindRecursive(root, value);
    }

    private bool FindRecursive(TreeNode node, T value)
    {
        if (node == null)
        {
            return false;
        }

        if (value.CompareTo(node.Value) == 0)
        {
            return true;
        }
        else if (value.CompareTo(node.Value) < 0)
        {
            return FindRecursive(node.Left, value);
        }
        else
        {
            return FindRecursive(node.Right, value);
        }
    }

    public void Remove(T value)
    {
        root = RemoveRecursive(root, value);
    }

    private TreeNode RemoveRecursive(TreeNode node, T value)
    {
        if (node == null)
        {
            return null;
        }

        if (value.CompareTo(node.Value) < 0)
        {
            node.Left = RemoveRecursive(node.Left, value);
        }
        else if (value.CompareTo(node.Value) > 0)
        {
            node.Right = RemoveRecursive(node.Right, value);
        }
        else
        {
            // Node with one child or no child
            if (node.Left == null)
            {
                return node.Right;
            }
            else if (node.Right == null)
            {
                return node.Left;
            }

            // Node with two children
            node.Value = FindMinValue(node.Right);
            node.Right = RemoveRecursive(node.Right, node.Value);
        }

        return node;
    }

    private T FindMinValue(TreeNode node)
    {
        T minValue = node.Value;
        while (node.Left != null)
        {
            minValue = node.Left.Value;
            node = node.Left;
        }
        return minValue;
    }
}

class Program
{
    static void Main()
    {
        BinarySearchTree<int> bst = new BinarySearchTree<int>();

        // Adding nodes to the tree
        bst.Add(50);
        bst.Add(30);
        bst.Add(70);
        bst.Add(20);
        bst.Add(40);
        bst.Add(60);
        bst.Add(80);

        // Traversing the tree
        Console.WriteLine("Preorder Traversal:");
        bst.PreorderTraversal();

        Console.WriteLine("Inorder Traversal:");
        bst.InorderTraversal();

        Console.WriteLine("Postorder Traversal:");
        bst.PostorderTraversal();

        // Searching for an element
        Console.WriteLine("Is 40 in the tree? " + bst.Find(40));
        Console.WriteLine("Is 90 in the tree? " + bst.Find(90));

        // Removing an element
        bst.Remove(30);
        Console.WriteLine("Inorder Traversal after removing 30:");
        bst.InorderTraversal();
    }
}
