class Solution:
    def plusOne(self, digits: List[int]) -> List[int]:
        i = len(digits) - 1
        
        # Changes all consecutive 9s to 0s
        while digits[i] == 9:
            digits[i] = 0
            i -= 1
        
        # If all integers were 9s, we add a 1 to the start of the list
        if i < 0:
            digits.insert(0, 1)
            
        # Else we increment the current index
        else:
            digits[i] += 1
        
        return digits