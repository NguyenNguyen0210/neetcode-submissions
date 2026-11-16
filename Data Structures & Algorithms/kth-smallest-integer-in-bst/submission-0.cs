/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    List<int> res = new();
    public int KthSmallest(TreeNode root, int k) {
        TreeToList(root);
        return res[k - 1];
    }
    private void TreeToList(TreeNode root){
        if (root == null) return;
        TreeToList(root.left);
        res.Add(root.val);
        TreeToList(root.right);
    }
}
