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
    // Iterative
    vector<int> postorderTraversal(TreeNode* root) {
        vector<int> ans;
        if (root == NULL) return ans;
        
        stack<TreeNode*> stack;
        stack.push(root);
        
        while (stack.size())
        {
            TreeNode* node = stack.top();
            stack.pop();
            
            ans.insert(ans.begin(), node->val);
            
            if (node->left != NULL) stack.push(node->left);
            if (node->right != NULL) stack.push(node->right);
        }
        
        return ans;
    }
    
    /*
    // Recursive
    vector<int> postorderTraversal(TreeNode* root) {
        vector<int> ans;
        if (root == NULL) return ans;
        helper(root, ans);
        return ans;
    }
    
    void helper(TreeNode* root, vector<int> &ans) {
        if (root == NULL) return;
        helper(root->left, ans);
        helper(root->right, ans);
        ans.push_back(root->val);
    }
    */
};