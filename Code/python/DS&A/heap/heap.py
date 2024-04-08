class Heap:
    def heapify(self, arr, size, index):
        largest = index
        left = 2 * index + 1
        right = 2 * index + 2

        if left < size and arr[index] < arr[left]:
            largest = left

        if right < size and arr[largest] < arr[right]:
            largest = right

        if largest != index:
            (arr[index], arr[largest]) = (arr[largest], arr[index])
            self.heapify(arr, size, largest)
    
    def heapSort(self, arr):
        size = len(arr)

        for index in range(size // 2 - 1, -1, -1):
            self.heapify(arr, size, index)

        for index in range(size - 1, 0, -1):
            (arr[index], arr[0]) = (arr[0], arr[index])
            self.heapify(arr, index, 0)
    
if __name__ == "__main__":
    h = Heap()
    arr = [3, 7, 2, 9, 5, 4, 8, 6, 1]

    h.heapSort(arr)

    for i in range(len(arr)):
        print(arr[i])