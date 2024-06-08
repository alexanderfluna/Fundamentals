/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode() : val(0), left(nullptr), right(nullptr) {}
 *     TreeNode(int x) : val(x), left(nullptr), right(nullptr) {}
 *     TreeNode(int x, TreeNode *left, TreeNode *right) : val(x), left(left), right(right) {}
 * };
 */
class Solution {
public:
    
    // Iterative solution
    bool hasPathSum(TreeNode* root, int targetSum) {
        if (!root) return false;

        stack<pair<TreeNode*, int>> s;
        s.push({root, root->val});

        while (s.size()) {
            pair<TreeNode*, int> p = s.top();
            TreeNode* node = p.first;
            int sum = p.second;
            s.pop();

            if (!node->left && !node->right) {
                if (sum  == targetSum) return true;
            } 
            else {
                if (node->left) {
                    s.push({node->left, sum + node->left->val});
                }
                if (node->right) {
                    s.push({node->right, sum + node->right->val});
                }
            }
        }

        return false;
    }
    
    
    /*
     // Recursive solution
    bool hasPathSum(TreeNode* root, int targetSum) {
        if (!root) return false;
        targetSum -= root->val;
        if (!root->left && !root->right && targetSum == 0) return true;
        return hasPathSum(root->left, targetSum) || hasPathSum(root->right, targetSum);
    }
    */
    
};