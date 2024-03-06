# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def deleteDuplicates(self, head: Optional[ListNode]) -> Optional[ListNode]:
        # Return if head is null
        if head is None:
            return None
        
        # Current points to head
        current = head
        
        # Iterate throuh linked list
        while current.next:
            
            # If the next value is a duplicate
            if current.val == current.next.val:
            
                # Point to the element after the next
                current.next = current.next.next
                
            # Else, point to the next element
            else:
                current = current.next
                
        return head
