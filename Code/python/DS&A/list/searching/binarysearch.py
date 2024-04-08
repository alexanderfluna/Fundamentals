def binarySearch(arr, val):
    low = 0
    high = len(arr) - 1

    while low <= high:
        mid = (high+low) // 2
        
        if arr[mid] == val:
            return True
        elif arr[mid] < val:
            low = mid + 1
        else:
            high = mid - 1

    return False
            
if __name__ == "__main__":
    arr = [1, 2, 3, 4, 5]
    print(binarySearch(arr, 2))
    print(binarySearch(arr, 8))
