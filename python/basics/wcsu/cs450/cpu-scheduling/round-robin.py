# Alexander Luna | Assignment 3 | 10/3/2023
# Round Robin CPU-Scheduling Algorithm

def round_robin(processes, burst_time, time_quantum):
    n = len(processes)
    
    # Create a queue to hold the processes
    queue = []
    
    # Create lists to store the remaining burst time and turnaround time for each process
    remaining_time = list(burst_time)
    turnaround_time = [0] * n
    
    # Initialize time and total waiting time
    time = 0
    total_waiting_time = 0
    
    while True:
        all_finished = True
        
        # Iterate through each process
        for i in range(n):
            if remaining_time[i] > 0:
                all_finished = False
                
                # Execute the process for the given time quantum or its remaining burst time
                if remaining_time[i] <= time_quantum:
                    # Process completes within time quantum
                    time += remaining_time[i]
                    total_waiting_time += time - burst_time[i]
                    remaining_time[i] = 0
                    turnaround_time[i] = time
                else:
                    # Process still has remaining burst time
                    time += time_quantum
                    remaining_time[i] -= time_quantum
                
                # Add the process back to the queue if it has remaining burst time
                if remaining_time[i] > 0:
                    queue.append(i)
        
        # If all processes are finished, break the loop
        if all_finished:
            break
        
        # Handle the processes in the queue
        while queue:
            process_index = queue.pop(0)
            
            # Execute the process for the given time quantum or its remaining burst time
            if remaining_time[process_index] <= time_quantum:
                time += remaining_time[process_index]
                total_waiting_time += time - burst_time[process_index]
                remaining_time[process_index] = 0
                turnaround_time[process_index] = time
            else:
                time += time_quantum
                remaining_time[process_index] -= time_quantum
                
                # Add the process back to the queue if it has remaining burst time
                queue.append(process_index)
    
    # Calculate the average waiting time and average turnaround time
    avg_waiting_time = total_waiting_time / n
    avg_turnaround_time = sum(turnaround_time) / n
    
    print(f"Average Waiting Time: {avg_waiting_time:.2f}")
    print(f"Average Turnaround Time: {avg_turnaround_time:.2f}")

# Example usage
if __name__ == "__main__":
    processes = ["P1", "P2", "P3"]
    burst_time = [4, 3, 5]
    time_quantum = 2

    round_robin(processes, burst_time, time_quantum)