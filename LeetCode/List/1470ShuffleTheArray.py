class Solution:
    def shuffle(self, nums: List[int], n: int) -> List[int]:
        i = 0
        j = n
        res = [0]*len(nums)

        for x in range(len(nums)):
            if x%2 == 0:
                res[x] = nums[i]
                i+=1
            else:
                res[x] = nums[j]
                j+=1
        return res