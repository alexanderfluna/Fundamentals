# Set
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        numbers = set()
        
        for i in range(len(nums)):
            if nums[i] in numbers:
                return True
            numbers.add(nums[i])

''' Sorting
class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        nums.sort()
        
        for i in range(len(nums) - 1):
            if nums[i] == nums[i+1]:
                return True
            
        return False
'''
