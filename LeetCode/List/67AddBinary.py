class Solution:
    def addBinary(self, a: str, b: str) -> str:
        i = len(a) - 1
        j = len(b) - 1
        carry = 0
        output = ""
        
        # iterate leftwards throuh strings until you finish one
        while i >= 0 or j >= 0:
            sum = carry;
            
            # If we have not reached the start of the string
                # The ord() function returns the number representing the unicode code of a specified character.
            if i >= 0 : sum += ord(a[i]) - ord('0')
            if j >= 0: sum += ord(b[j]) - ord('0')
            
            i -= 1
            j -= 1
            
            carry = 1 if sum > 1 else 0;
            
            output += str(sum % 2)
            
        if carry != 0 : output += str(carry);
        return output[::-1]