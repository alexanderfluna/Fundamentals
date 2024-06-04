/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */
class Solution {
public:
    ListNode* addTwoNumbers(ListNode* l1, ListNode* l2) {
        int sum, carry = 0;
        ListNode* l3 = new ListNode(0);
        ListNode* node = l3;

        while (l1 || l2 || carry){
            sum = carry + (l1 ? l1->val : 0) + (l2 ? l2->val : 0);
            carry = sum / 10;
            
            ListNode* new_node = new ListNode(sum % 10);
            
            node->next = new_node;
            node = node->next;
            
            if (l1) l1=l1->next;
            if (l2) l2=l2->next;
        }
        return l3->next;
    }
};