# Michael Oviedo and Alexander Luna | Alpha - Beta Pruning

# Alpha-Beta pruning is not actually a new algorithm, 
# but rather an optimization technique for the minimax algorithm.
# It is called Alpha-Beta pruning because it passes 2 extra 
# parameters in the minimax function, namely alpha and beta.

# Input: node - the current node
# Input: depth - the current level of the tree
# Input: maximizing_player - the current player
# Input: alpha - the best value at that level or above
# Input: beta - the best value at that level or below
def alpha_beta(node, depth, maximizing_player, alpha, beta):
    
    # Base case: return the value of the node if it is a leaf node or if we have reached the desired depth
    if depth == 3 or 'value' in node:
        return node.get('value', 0)
    
    # Maximizing player's turn
    if maximizing_player:
        max_eval = float('-inf')  # Initialize max evaluation to negative infinity
        for child in node.get('children', []):  # Loop through all child nodes
            eval = alpha_beta(child, depth + 1, False, alpha, beta)  # Recursive call for child node
            max_eval = max(max_eval, eval)  # Update max_eval if we find a larger value
            alpha = max(alpha, eval)  # Update alpha value
            if beta <= alpha:
                break  # Beta cut-off: No need to explore further
        return max_eval  # Return the best evaluation from this node
    else:
        # Minimizing player's turn
        min_eval = float('inf')  # Initialize min evaluation to infinity
        for child in node.get('children', []):  # Loop through all child nodes
            eval = alpha_beta(child, depth + 1, True, alpha, beta)  # Recursive call for child node
            min_eval = min(min_eval, eval)  # Update min_eval if we find a smaller value
            beta = min(beta, eval)  # Update beta value
            if beta <= alpha:
                break  # Alpha cut-off: No need to explore further
        return min_eval  # Return the best (smallest) evaluation from this node

# Define the example game tree
# This tree is structured with each node potentially having children
# Leaf nodes have actual scores (values) while internal nodes lead to further possibilities
game_tree = {
    'children': [  # Level 1: Root node's children
        {'children': [  # Level 2: Children of the first child of the root
            {'value': 5},  # Level 3: Leaf node with a value
            {'value': 3}
        ]},
        {'children': [  # Similarly, more children at Level 2
            {'value': 2},
            {'value': 9}
        ]},
        {'children': [
            {'value': 0},
            {'value': 1}
        ]},
        {'children': [
            {'value': 4},
            {'value': 1}
        ]}
    ]
}

# Function to print the tree structure
def print_tree(node, depth=0):
    if 'children' in node:
        print("  " * depth, end="")
        print("└─")
        for child in node['children']:
            print_tree(child, depth + 1)
    elif 'value' in node:
        print("  " * depth, end="")
        print("└─", node['value'])
        

if __name__ == "__main__":        
    # Print the tree structure
    print("Tree Structure:")
    print_tree(game_tree)

    # Execute the alpha-beta pruning algorithm
    # Starting with maximum depth (3 in this case), alpha (-infinity), beta (+infinity), and the maximizing player
    best_value = alpha_beta(game_tree, depth=0, maximizing_player=True, alpha=float('-inf'), beta=float('inf'))
    print("The best value achievable is:", best_value)