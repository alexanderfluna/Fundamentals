class Solution:
    def twoSum(self, nums, target):
        hashmap = {}
        
        for index, num in enumerate(nums):
            if num in hashmap:
                print("Indexes:")
                print(hashmap[num], index)

                print("Values:")
                print(nums[hashmap[num]], nums[index])

                return(hashmap[num], index)
            else:
                hashmap[target - num] = index
            
if __name__ == "__main__":
    s = Solution()

    arr = [1, 2, 3, 4, 5]
    answer = []

    target = 7

    answer = s.twoSum(arr, target)