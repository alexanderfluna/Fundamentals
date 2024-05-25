# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next
class Solution:
    def isPalindrome(self, head: Optional[ListNode]) -> bool:
        slow = head
        fast = head
        
        while fast != None and fast.next != None:
            slow = slow.next
            fast = fast.next.next
            
        slow = self.reverse(slow)
        fast = head
        
        while slow != None:
            if slow.val != fast.val:
                return False
            slow = slow.next
            fast = fast.next
            
        return True
        
    def reverse(self, head):
        prev = None
        
        while head != None:
            subsequent = head.next
            head.next = prev
            prev = head
            head = subsequent
            
        return prev