# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def inorderTraversal(self, root):
        res = []
        self.helper(root, res)
        return res
    
    def helper(self, root, res):
        if root:
            self.helper(root.left, res)
            res.append(root.val)
            self.helper(root.right, res)

# One-line solution: 
            
#class Solution:
#    def inorderTraversal(self, root):
#        return self.inorderTraversal(root.left) + [root.val] + self.inorderTraversal(root.right) if root else []