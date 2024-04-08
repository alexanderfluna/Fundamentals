class tree_node:
    def __init__(self, data):
        self.data = data
        self.left = None
        self.right = None

    def insert(self, root, data):
        if root is None:
            root = tree_node(data)
            return root
        
        if data < root.data:
            root.left = root.insert(root.left, data)
        else:
            root.right = root.insert(root.right, data)

        return root
    
    def preorder(self, root):
        if root is None:
            return
        print(root.data, end = ' ')
        root.preorder(root.left)
        root.preorder(root.right)

    def inorder(self, root):
        if root is None:
            return
        root.inorder(root.left)
        print(root.data, end = ' ')
        root.inorder(root.right)

    def postorder(self, root):
        if root is None:
            return
        root.postorder(root.left)
        root.postorder(root.right)
        print(root.data, end = ' ')

if __name__ == "__main__":
    root = tree_node(5)
    root.insert(root, 9)
    root.insert(root, 3)
    root.insert(root, 6)
    root.insert(root, 1)
    root.insert(root, 2)
    root.insert(root, 8)
    root.insert(root, 7)
    root.insert(root, 4)

    print("Preorder:")
    root.preorder(root)

    print("\nInorder:")
    root.inorder(root)

    print("\nPostorder:")
    root.postorder(root)