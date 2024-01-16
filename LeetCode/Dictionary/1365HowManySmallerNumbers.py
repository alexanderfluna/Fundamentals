class Solution:
    def smallerNumbersThanCurrent(self, nums: List[int]) -> List[int]:
        sorted_arr=sorted(nums)

        dict={}
        answer=[]

        for i in range(len(sorted_arr)):
            if sorted_arr[i] not in dict:
                dict[sorted_arr[i]]=i

        for i in range(len(nums)):
            answer.append(dict[nums[i]])

        return answer