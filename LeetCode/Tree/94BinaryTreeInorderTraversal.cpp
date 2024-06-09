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
    vector<int> inorderTraversal(TreeNode* root) {
        vector<int> ans;
        if (root == NULL) return ans;
        
        stack<TreeNode*> stack;
        
        while (root != NULL || stack.size())
        {
            while (root != NULL)
            {
                stack.push(root);
                root = root->left;
            }

            root = stack.top();
            stack.pop();

            ans.push_back(root->val);
            
            root = root->right;
        }
        
        return ans;
    }
    
    /*
    // Recursive
    vector<int> inorderTraversal(TreeNode* root) {
        vector<int> ans;
        if (root == NULL) return ans;
        helper(root, ans);
        return ans;
    }
    
    void helper(TreeNode* root, vector<int> &ans) {
        if (root == NULL) return;
        helper(root->left, ans);
        ans.push_back(root->val);
        helper(root->right, ans);
    }
    */
};