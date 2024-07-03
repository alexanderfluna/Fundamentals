# Alexander Luna | Assignment 3 | 10/3/2023
# Priority CPU Scheduling Algorithm

def priority_scheduling(processes):
    n = len(processes)
    
    # Sort processes by priority (lower number means higher priority)
    processes.sort(key=lambda x: x[2])
    
    waiting_time = [0] * n
    turnaround_time = [0] * n
    
    waiting_time[0] = 0
    turnaround_time[0] = processes[0][1]
    
    # Calculate waiting time and turnaround time for each process
    for i in range(1, n):
        waiting_time[i] = turnaround_time[i - 1]
        turnaround_time[i] = waiting_time[i] + processes[i][1]
    
    # Calculate average waiting time and turnaround time
    avg_waiting_time = sum(waiting_time) / n
    avg_turnaround_time = sum(turnaround_time) / n
    
    # Print the results
    print("Process\tBurst Time\tPriority")
    for process in processes:
        print(f"{process[0]}\t{process[1]}\t\t{process[2]}")
    
    print(f"Average Waiting Time: {avg_waiting_time:.2f}")
    print(f"Average Turnaround Time: {avg_turnaround_time:.2f}")

if __name__ == "__main__":
    # Example processes: (pid, burst_time, priority)
    processes = [
        (1, 3, 1),
        (2, 4, 3),
        (3, 2, 2),
        (4, 1, 1),
        (5, 3, 4)
    ]
    
    priority_scheduling(processes)