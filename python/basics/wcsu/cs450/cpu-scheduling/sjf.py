# Alexander Luna | Assignment 3 | 10/3/2023
# Shorted Job First CPU Scheduling Algorithm

def sjf(processes, burst_time, arrival_time):
    n = len(processes)
    
    # Create a list to store the order of execution
    execution_order = []
    
    # Copy the burst_time and arrival_time lists to avoid modifying the originals
    burst_time_copy = burst_time.copy()
    arrival_time_copy = arrival_time.copy()
    
    # Initialize total waiting time and total turnaround time
    total_waiting_time = 0
    total_turnaround_time = 0
    
    # Initialize the current time
    current_time = 0
    
    while True:
        # Create a list to store the indices of processes that have arrived
        available_processes = []
        
        # Check which processes have arrived at the current time
        for i in range(n):
            if arrival_time_copy[i] <= current_time:
                available_processes.append(i)
        
        # If no processes have arrived, move time forward to the next arrival time
        if not available_processes:
            current_time = min(arrival_time_copy)
            continue
        
        # Find the process with the shortest burst time among the available processes
        shortest_burst_index = min(available_processes, key=lambda x: burst_time_copy[x])
        process = processes[shortest_burst_index]
        
        # Update the execution order and calculate waiting and turnaround time
        execution_order.append(process)
        total_waiting_time += current_time - arrival_time[shortest_burst_index]
        current_time += burst_time[shortest_burst_index]
        total_turnaround_time += current_time - arrival_time[shortest_burst_index]
        
        # Mark this process as completed by setting its burst time to a large value
        burst_time_copy[shortest_burst_index] = float('inf')
        
        # If all processes are completed, exit the loop
        if len(execution_order) == n:
            break

    # Calculate the average waiting time and average turnaround time
    avg_waiting_time = total_waiting_time / n
    avg_turnaround_time = total_turnaround_time / n
    
    return execution_order, avg_waiting_time, avg_turnaround_time

if __name__ == "__main__":
    processes = [1, 2, 3, 4]
    burst_time = [8, 6, 4, 2]
    arrival_time = [0, 1, 2, 2]

    execution_order, avg_waiting_time, avg_turnaround_time = sjf(processes, burst_time, arrival_time)

    print("Execution Order:", execution_order)
    print("Average Waiting Time:", avg_waiting_time)
    print("Average Turnaround Time:", avg_turnaround_time)