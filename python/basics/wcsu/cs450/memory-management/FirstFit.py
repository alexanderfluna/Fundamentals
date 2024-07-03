# Alexander Luna | First Fit 

def firstFit(free_blocks_of_memory, memory_chunks):
    # Iterate through memory chunks
    for i in range(len(memory_chunks)):
        
        # Iterate through free blocks of memory
        for j in range(len(free_blocks_of_memory)):
            
            # Check if memory chunks is less than or equal to the free block of memory
            if memory_chunks[i] <= free_blocks_of_memory[j]:
                
                # Subtract the memory chunk from the free block of memory
                free_blocks_of_memory[j] -= memory_chunks[i]
                print(f"{memory_chunks[i]}: {free_blocks_of_memory}")
                
                # Break from current for loop
                break
    
if __name__ == "__main__":
    free_blocks_of_memory = [10, 4, 20, 18, 7, 9 ,12]
    print(f"Free blocks of memory: {free_blocks_of_memory}")
    
    memory_chunks = [12, 10, 6]
    print(f"Memory chunks: {memory_chunks}\n")
    
    print(f"First Fit Algorithm:")
    firstFit(free_blocks_of_memory, memory_chunks);