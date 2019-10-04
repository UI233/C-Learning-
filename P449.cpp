/**
 * Definition for a binary tree node.
 * struct TreeNode {
 *     int val;
 *     TreeNode *left;
 *     TreeNode *right;
 *     TreeNode(int x) : val(x), left(NULL), right(NULL) {}
 * };
 */
#include <iostream>
class Codec {
public:

    // Encodes a tree to a single string.
    string serialize(TreeNode* root) {
        if (root == NULL)
            return "";
        auto v = std::to_string(root->val);
        string ans = v;
        if (root -> left) 
            ans =  "(" + serialize(root -> left) + ")"  + ans;
        if (root -> right)
            ans =  ans + "(" + serialize(root -> right) + ")" ;
        return ans;
    }

    // Decodes your encoded data to tree.
    TreeNode* deserialize(string data) {
        if (data.length() == 0)
            return NULL;
        int cnt = 0;
        int st = 0;
        do {
            if (data[st] == '(')
                ++cnt;
            else if (data[st] == ')')
                --cnt;
            ++st;
        }while(cnt != 0);
        
        if (data[0] != '(')
            st = 0;
        
        int ed = st;
        for (; ed < data.length() && data[ed] != '(' ; ++ed);
        int v = std::stoi(data.substr(st, ed - st));
        
        TreeNode *now = new TreeNode(v);
        if (st != 0)
            now -> left = deserialize(data.substr(1, st - 2));
        if (ed != data.length())
            now -> right = deserialize(data.substr(ed + 1, data.length() - ed - 2));
        return now;
    }
};

// Your Codec object will be instantiated and called as such:
// Codec codec;
// codec.deserialize(codec.serialize(root));