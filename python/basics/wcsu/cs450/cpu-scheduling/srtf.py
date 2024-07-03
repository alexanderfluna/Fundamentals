# Alexander Luna | Assignment 3 | 10/3/2023
# Shortest Remaining Time First CPU Scheduling Algorithm
  
# Function to find the waiting time 
# for all processes 
def findWaitingTime(processes, waiting_time): 
    n = len(processes)

    remaining_time = [0] * n
  
    # Copy the burst time into remaining_time[] 
    for i in range(n): 
        remaining_time[i] = processes[i][1]
    complete = 0
    time = 0
    minm = 999999999
    short = 0
    check = False
  
    # Process until all processes gets 
    # completed 
    while (complete != n):
          
        # Find process with minimum remaining 
        # time among the processes that 
        # arrives till the current time`
        for j in range(n):
            if ((processes[j][2] <= time) and 
                (remaining_time[j] < minm) and remaining_time[j] > 0):
                minm = remaining_time[j]
                short = j
                check = True
        if (check == False):
            time += 1
            continue
              
        # Reduce remaining time by one 
        remaining_time[short] -= 1
  
        # Update minimum 
        minm = remaining_time[short] 
        if (minm == 0): 
            minm = 999999999
  
        # If a process gets completely 
        # executed 
        if (remaining_time[short] == 0): 
  
            # Increment complete 
            complete += 1
            check = False
  
            # Find finish time of current 
            # process 
            fint = time + 1
  
            # Calculate waiting time 
            waiting_time[short] = (fint - processes[short][1] -    
                                processes[short][2])
  
            if (waiting_time[short] < 0):
                waiting_time[short] = 0
          
        # Increment time 
        time += 1
  
# Function to calculate turn around time 
def findTurnAroundTime(processes, waiting_time, turnaround_time): 
    n = len(processes)
      
    # Calculating turnaround time 
    for i in range(n):
        turnaround_time[i] = processes[i][1] + waiting_time[i] 
  
# Function to calculate average waiting 
# and turn-around times. 
def srtf(processes): 
    n = len(processes)
    
    # Initialize waiting time and turnaround time arrays with zeros
    waiting_time = [0] * n
    turnaround_time = [0] * n 
  
    # Function to find waiting time 
    # of all processes 
    findWaitingTime(processes, waiting_time) 
  
    # Function to find turn around time
    # for all processes 
    findTurnAroundTime(processes, waiting_time, turnaround_time) 
  
    # Display processes along with all details 
    print("Processes    Burst Time     Waiting", 
                    "Time     Turn-Around Time")
    total_waiting_time = 0
    total_turnaround_time = 0

    # Print the results
    for i in range(n):
        total_waiting_time += waiting_time[i] 
        total_turnaround_time += turnaround_time[i] 
        print(" ", processes[i][0], "\t\t", 
                   processes[i][1], "\t\t", 
                   waiting_time[i], "\t\t", turnaround_time[i])
  
    print(f"\nAverage waiting time = {total_waiting_time /n:.2f}")
    print(f"Average turn around time = {total_turnaround_time / n:.2f}")
      
if __name__ =="__main__":

    # Process id, Burst Time, Arrival Time
    processes = [[1, 7, 0], [2, 3, 1], [3, 4, 3]]
    #processes = [[1, 8, 0], [2, 6, 1], [3, 4, 2], [4, 2, 2]]
    srtf(processes)