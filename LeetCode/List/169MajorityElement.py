class Solution:
    # Dictionary
    def majorityElement(self, nums: List[int]) -> int:
        n = len(nums)
        dictionary = defaultdict(int)
        
        for num in nums:
            dictionary[num] += 1;
            
        n = n//2
        
        for key, value in dictionary.items():
            if value > n:
                return key
            
        return 0
    
    '''
    # Moore Voting Algorithm
    def majorityElement(self, nums: List[int]) -> int:
        candidate = nums[0]
        count = 1
        
        for i in range(1, len(nums)):
            if count == 0:
                candidate = nums[i]
                
            count += 1 if candidate == nums[i] else -1
                
        return candidate
    '''