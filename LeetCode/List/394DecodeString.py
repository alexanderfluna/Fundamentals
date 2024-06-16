class Solution:
    def decodeString(self, s: str) -> str:
        stack = []
        
        for character in s:
            if character != "]":
                stack.append(character)
                
            else:
                substring = ""
                
                while stack[-1] != "[":
                    substring = stack.pop() + substring
                    
                stack.pop()
                
                number = ""
                
                while stack and stack[-1].isdigit():
                    number = stack.pop() + number
                     
                stack.append(int(number) * substring)
                
        return "".join(stack)