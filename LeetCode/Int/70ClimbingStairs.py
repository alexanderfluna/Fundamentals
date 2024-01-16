class Solution:
    def climbStairs(self, n):
        left = 0
        right = 1
        for i in range(1, n+1):
            ans = left + right
            left = right
            right = ans
        return ans 