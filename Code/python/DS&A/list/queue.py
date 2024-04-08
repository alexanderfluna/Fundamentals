queue = []

queue.append('a')
queue.append('b')
queue.append('c')

print('Initial queue')
print(queue)

print('\nElements popped from queue')
print(queue.pop(0))
print(queue.pop(0))
print(queue.pop(0))

print('\nQueue after elements are popped')
print(queue)