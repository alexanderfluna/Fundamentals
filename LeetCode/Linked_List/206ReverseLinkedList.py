# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        list_iterator = head
        reverse_list_iterator = None
        
        while list_iterator != None:
            list_iterator = head.next
            head.next = reverse_list_iterator
            reverse_list_iterator = head
            head = list_iterator
            
        return reverse_list_iterator