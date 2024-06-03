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
    public int minDepth(TreeNode root) {
        if(root == null) return 0;
        List<TreeNode> list = new LinkedList<>();
        list.add(root);
        int level = 1;
        while(!list.isEmpty()){
            int len = list.size();
            for(int i = 0;i<len;i++){
                TreeNode node = list.remove(0);
                if(node.left == null && node.right == null) return level;
                if(node.left != null) list.add(node.left);
                if(node.right != null) list.add(node.right);
            }
            level++;
        }
        return 0;
    }
}