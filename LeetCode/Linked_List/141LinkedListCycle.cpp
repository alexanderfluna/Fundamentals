/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode(int x) : val(x), next(NULL) {}
 * };
 */
class Solution {
public:
    
    // Using a fast/slow pointer
    bool hasCycle(ListNode *head) {
        ListNode* slow=head;
        ListNode* fast=head;
        
        while(fast!=NULL && fast->next!=NULL){
            fast=fast->next->next;
            slow=slow->next;
            if(slow==fast) return true;
        }
        return false;
    }
    
    /*
    // Using the max number of nodes in the list
    bool hasCycle(ListNode *head) {
        int count = 0;
        
        while (head != NULL)
        {
            head = head->next;
            if (count == 10000) return true;
            count++;
        }
        
        return false;
    }
    */
};