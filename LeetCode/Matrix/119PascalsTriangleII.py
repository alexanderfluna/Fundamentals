class Solution:
    def getRow(self, rowIndex: int) -> List[int]:
        triangle = [[1]]
        
        for i in range(1, rowIndex + 1):
            triangle.append([1])
            
            for j in range(1, len(triangle[i-1])):
                triangle[i].append(triangle[i-1][j-1] + triangle[i-1][j])
                
            triangle[i].append(1)
            
        return triangle[-1]