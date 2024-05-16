# Definition for a binary tree node.
# class TreeNode:
#     def __init__(self, val=0, left=None, right=None):
#         self.val = val
#         self.left = left
#         self.right = right
class Solution:
    def isBalanced(self, root: Optional[TreeNode]) -> bool:
        return self.Height(root) >= 0
    
    def Height(self, root):
        if root is None:  
            return 0
        
        leftheight = self.Height(root.left)
        rightheight = self.Height(root.right)
        
        if leftheight < 0 or rightheight < 0 or abs(leftheight - rightheight) > 1:  
            return -1
        
        return max(leftheight, rightheight) + 1