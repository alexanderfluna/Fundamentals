# Merge Sort is a Divide and Conquer algorithm. It divides the input array in two halves,
# calls itself to sort the two halves, and then merges the two sorted halves

def merge(arr, low, middle, high):
    
    # Stores the size of the left and right subarrays
    n1 = middle - low + 1
    n2 = high - middle
    
    # Creates temp arrays
    L = [0] * (n1)
    R = [0] * (n2)
    
    # Copy data from arr into temp arrays
    for i in range(n1):
        L[i] = arr[low + i]
        
    for j in range(n2):
        R[j] = arr[middle + 1 + j]
        
    # Merge the temp arrays back into arr
    i = 0       # Initial index of first subarray
    j = 0       # Initial index of second subarray
    k = low     # Initial index of merged subarray
    
    while i < n1 and j < n2:
        if L[i] <= R[j]:
            arr[k] = L[i]
            i += 1
        else:
            arr[k] = R[j]
            j += 1
        k += 1
        
    # Copies any remaining elements of L[]
    while i < n1:
        arr[k] = L[i]
        i += 1
        k += 1
        
    # Copies any remaining elements of R[]
    while j < n2:
        arr[k] = R[j]
        j += 1
        k += 1 

def mergeSort(arr, low, high):
    if low < high:
        
        # Calculates the index of the median
        middle = low + (high - low) // 2
        
        # Recursively sorts the left half and right half of the array
        mergeSort(arr, low, middle)
        mergeSort(arr, middle + 1, high)
        
        # Merges the two subarrays together
        merge(arr, low, middle, high)

if __name__ == "__main__":
    arr = [3, 2, 5, 0, 1, 8, 7, 6, 9, 4, -1]
    
    print(arr)
    
    mergeSort(arr, 0, len(arr) - 1)

    print(arr)
