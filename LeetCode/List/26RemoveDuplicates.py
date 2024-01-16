class Solution:
    def removeDuplicates(self, nums: List[int]) -> int:
        unique_set = list(set(nums))
        unique_set.sort()
        for i in range(len(unique_set)):
            nums[i] = unique_set[i]
        
        return len(unique_set)