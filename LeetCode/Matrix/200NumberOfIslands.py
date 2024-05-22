class Solution:
    def numIslands(self, grid: List[List[str]]) -> int:
        number_of_islands = 0
        
        for i in range(len(grid)):
            for j in range (len(grid[i])):
                if grid[i][j] == "1":
                    number_of_islands += 1
                    self.BFS(grid, i, j)
        
        return number_of_islands
    
    def BFS(self, grid, i, j):
        if i < 0 or i >= len(grid) or j < 0 or j >= len(grid[i]) or grid[i][j] == "0":
            return
        
        grid[i][j] = "0"
        self.BFS(grid, i-1, j)
        self.BFS(grid, i+1, j)
        self.BFS(grid, i, j-1)
        self.BFS(grid, i, j+1)