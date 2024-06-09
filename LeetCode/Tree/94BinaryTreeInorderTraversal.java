/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     int val;
 *     TreeNode left;
 *     TreeNode right;
 *     TreeNode() {}
 *     TreeNode(int val) { this.val = val; }
 *     TreeNode(int val, TreeNode left, TreeNode right) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
class Solution {
    // Iterative
    public List<Integer> inorderTraversal(TreeNode root) {
        List<Integer> ans = new ArrayList<>();
        if (root == null) return ans;
        
        Stack<TreeNode> stack = new Stack<>();
        TreeNode curr = root;
        
        while (curr != null || !stack.isEmpty())
        {
            while (curr != null)
            {
                stack.push(curr);
                curr = curr.left;
            }
            curr = stack.pop();
            ans.add(curr.val);
            curr = curr.right;
        }
        
        return ans;
    }
    
    /*
    // Recursive
    public List<Integer> inorderTraversal(TreeNode root) {
        List<Integer> ans = new ArrayList<>();
        helper(root, ans);
        return ans;
    }
    
    public void helper(TreeNode root, List<Integer> ans) {
        if (root == null) return;
        helper(root.left, ans);
        ans.add(root.val);
        helper(root.right, ans);
    }
    */
}