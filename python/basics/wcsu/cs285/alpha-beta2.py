# Michael Oviedo and Alexander Luna | Alpha - Beta Pruning

# Alpha-Beta Pruning is not actually a new algorithm, 
# but rather an optimization technique for the minimax algorithm.
# It is called Alpha-Beta pruning because it passes 2 extra 
# parameters in the minimax function, namely alpha and beta.
 
# Input: depth - the current level of the tree
# Input: node - the current node
# Input: maximizing_player - the current player
# Input: alpha - the best value at that level or above
# Input: beta - the best value at that level or below
def alpha_beta(depth, node, maximizingPlayer, 
            values, alpha, beta): 
  
    # Base case: return the value of the node if it is a leaf node 
    if depth == 3: 
        return values[node] 
 
    # Maximizing player's turn
    if maximizingPlayer: 
      
        # Initialize to negative infinity
        max_eval = MIN
 
        # Recursive call for left and right children 
        for i in range(0, 2): 

            # Recursive call for child node
            val = alpha_beta(depth + 1, node * 2 + i, 
                          False, values, alpha, beta) 
            
             # Update max_eval if we find a larger value
            max_eval = max(max_eval, val) 

            # Update alpha value if max_eval is larger
            alpha = max(alpha, max_eval) 
 
            # Alpha Beta Pruning 
            if beta <= alpha: 
                break # Beta cut-off: No need to explore further
          
        # Return the max evaluation from this node
        return max_eval 
      
    # Minimizing player's turn
    else:

        # Initialize min evaluation to infinity
        min_eval = MAX
 
        # Recursive call for left and right children  
        for i in range(0, 2): 
          
            # Recursive call for child node
            val = alpha_beta(depth + 1, node * 2 + i, 
                            True, values, alpha, beta) 
            
            # Update min_eval if we find a smaller value
            min_eval = min(min_eval, val) 

            # Update beta value if min_eval is smaller
            beta = min(beta, min_eval) 
 
            # Alpha Beta Pruning 
            if beta <= alpha: 
                break # Alpha cut-off: No need to explore further
          
        # Return the smallest evaluation from this node
        return min_eval 
    
def printNodes(values):
    print("Alpha-Beta Pruning Algorithm\n")
    print("The leaf nodes of the tree are:")
    for value in values:
        print(value, end=" ")
    print("\n")

      
if __name__ == "__main__": 
    MIN = float('-inf')  # Initialize min evaluation to negative infinity
    MAX = float('inf')  # Initialize max evaluation to infinity
    values = [3, 5, 6, 9, 1, 2, 0, -1]  
    printNodes(values)
    print("The optimal value is:", alpha_beta(0, 0, True, values, MIN, MAX)) 