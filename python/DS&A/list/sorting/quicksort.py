# QuickSort is a divide and conquer algorithm. First, we pick the last element as the
# pivot and partition the array around that pivot. Then we recursively sort the left 
# side of the pivot and the right side of the pivot. We do this by using the last
# element of each subarray as the new pivot and partitioning each subarray

def partition(arr, low, high):
    
    # Chooses the rightmost element as the pivot
    pivot = arr[high]
    
    # Points to the index behind the leftmost element
    i = low - 1
    
    # Iterate from the leftmost element to the rightmost element
    # and compare each element to the pivot
    for j in range(low, high):
        if arr[j] <= pivot:
            
            # If the current element is smaller than the pivot
            # i will point to the next element
            i += 1
            
            # If the current element is smaller than what is pointed to
            # by i, swap the current element and i
            if arr[j] < arr[i]:
                print(arr[i], arr[j])
                (arr[i], arr[j]) = (arr[j], arr[i])
                print(arr)
            
    # Swap the pivot with the element pointed to by i
    print(arr[i+1], arr[high])
    (arr[i + 1], arr[high]) = (arr[high], arr[i + 1])
    print(arr)
    
    # Return the position from where the partition is done
    return i + 1

def quickSort(arr, low, high):
    if low < high:
        
        # Finds a pivot element such that the
        # elements smaller than the pivot are on the left
        # elements greater than the pivot are on the right
        pivot = partition(arr, low, high)
        
        # Recursively sorts the left of the pivot
        quickSort(arr, low, pivot - 1)
        
        # Recursively sorts the right of the pivot
        quickSort(arr, pivot + 1, high)
    
if __name__ == "__main__":
    arr = [3, 2, 5, 0, 1, 8, 7, 6, 9, 4, -1]
    
    print(arr)
    
    quickSort(arr, 0, len(arr) - 1)
