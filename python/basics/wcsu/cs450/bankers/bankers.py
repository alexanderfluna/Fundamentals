# Alexander Luna | Banker's Algorithm
 
if __name__=="__main__":
     
     # Initialize variables
    number_of_processes = 5
    number_of_resources = 4
     
    allocation_matrix = [
        [0, 1, 1, 0],
        [1, 2, 3, 1],
        [1, 3, 6, 5],
        [0, 6, 3, 2],
        [0, 0, 1, 4]
    ]
     
    max_matrix = [
        [0, 2, 1, 0],
        [1, 6, 5, 2],
        [2, 3, 6, 6],
        [0, 6, 5, 2],
        [0, 6, 5, 6]
    ]
     
    available = [1, 5, 2, 0]
    finish_matrix = [False] * number_of_processes
    answer = [0] * number_of_processes
    index = 0 # Used for the index of answer array
         
    # Create the need matrix
    need_matrix = [[ 0 for i in range(number_of_resources)]for i in range(number_of_processes)]
    for i in range(number_of_processes): # Iterate through each row/process
        for j in range(number_of_resources): # Iterate through each column/resource
            need_matrix[i][j] = max_matrix[i][j] - allocation_matrix[i][j]

    # SAFETY ALGORITHM:
    # Iterate through each row/process
    # The hope is that at least one process will be set to true every iteration
    for process in range(number_of_processes):

        # Iterate through each row/process
        for i in range(number_of_processes):

            # If the process is set to false in finish_matrix, we will iterate through its resources
            # Else if the process is set to true, we will skip this process
            if (finish_matrix[i] == False):

                # Remains 0 if we have enough available resources
                # Changes to 1 if we have do not have enough available resources
                flag = 0 

                # Iterate through each column/resource
                for j in range(number_of_resources):

                    # If the need of any resource is greater than what 
                    # we have available, we will skip this process
                    if (need_matrix[i][j] > available[j]):
                        flag = 1
                        break
                 
                 # If flag == 0, we have enough resources available for this process and will enter the scope
                 # Else if flag == 1, we do not have enough resources available and will skip this process
                if (flag == 0):

                    # Stores the process number in answer and increments the index of answer by 1
                    answer[index] = i
                    index += 1

                    # Adds the resources the process had allocated to available array
                    for resource in range(number_of_resources):
                        available[resource] += allocation_matrix[i][resource]

                    # Set the process to true in finish_matrix
                    finish_matrix[i] = True
                     
    # Prints the safe sequence
    print("Following is the SAFE Sequence")
    for i in range(number_of_processes - 1):
        print(" P", answer[i], " ->", sep="", end="")
    print(" P", answer[number_of_processes - 1], sep="")