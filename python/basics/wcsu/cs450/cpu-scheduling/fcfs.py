# Alexander Luna | Assignment 3 | 10/3/2023
# First Come First Serve CPU Scheduling Algorithm

def fcfs(processes, burst_times):
    n = len(processes)
    
    # Initialize waiting time and turnaround time arrays with zeros
    waiting_time = [0] * n
    turnaround_time = [0] * n
    
    # Calculate waiting time for each process
    for i in range(1, n):
        waiting_time[i] = burst_times[i - 1] + waiting_time[i - 1]
    
    # Calculate turnaround time for each process
    for i in range(n):
        turnaround_time[i] = burst_times[i] + waiting_time[i]
    
    # Calculate average waiting time and average turnaround time
    avg_waiting_time = sum(waiting_time) / n
    avg_turnaround_time = sum(turnaround_time) / n
    
    # Print the results
    print("Process\tBurst Time\tWaiting Time\tTurnaround Time")
    for i in range(n):
        print(f"P{i}\t\t{burst_times[i]}\t\t{waiting_time[i]}\t\t{turnaround_time[i]}")
    
    print(f"Average Waiting Time: {avg_waiting_time:.2f}")
    print(f"Average Turnaround Time: {avg_turnaround_time:.2f}")

if __name__ == "__main__":
    processes = ["P1", "P2", "P3"]
    burst_times = [24, 3, 3]
    
    fcfs(processes, burst_times)