print("Lesson 13: The List Data Type")
print("\n")


print("Single list:")

# Foo is a list 
foo = ["cat", "bat", "rat", "elephant"]

# Prints the entire list
print(foo)

# Prints the value of the index inside the list
print(foo[0], foo[1], foo[2], foo[3])

# For loop that increments to each of the indexes in the list
for i in range(len(foo)):
    print("...foo[" + str(i) + "]=" + foo[i], end='')
print("\n")


print("\n________________________________________________________________________________")


print("List of lists:")

# Spam is a list of lists
spam = [["blue", "cheese"], [10, 20, 30, 40, 50]]

# Prints all lists in the list
print(spam)

# Uses two indexes to print out the value of the index inside one of the lists
print(spam[0][0], spam[0][1], spam[1][0], spam[1][1], spam[1][2], spam[1][3], spam[1][4])

# For loop that increments to each of the indexes in the first list
for i in range(1):
    for j in range(2):
        print("...spam[" + str(i) + "][" + str(j) + "]=" + spam[i][j], end='')

# For loop that increments to each of the indexes in the second list
for i in range(1, 2):
    for j in range(5):
        print(f"..spam[{i}][{j}]= {spam[i][j]}", end='')
print("\n")


print("\n________________________________________________________________________________")


print("Negative indexes:")

# Bar is a list
bar = ["eggs", "bacon", "sausage", "pancakes"]

# [-1] = last index in the list. [-2] = second to last index in the list and so on.
print(bar[-1], bar[-2], bar[-3], bar[-4])


print("\n________________________________________________________________________________")


print("Slices:")

# Creates a slice called bar, which is a brand new list made from the original list
# A slice is a list of values instead of indexes which are a single value
# The [1:3] means the new list will start from index 1 & go up to but not include index 3
print(bar[1:3])

# The slice is confined to when it's called. The OG bar is still intact as its own list.
print(bar)


print("\n________________________________________________________________________________")


print("Changing a list's items:")

# Ham is a list
ham = [10, 20, 30, 40, 50]
print(ham)

# You can use an index to change the value of whatever is in the index
ham[4] = "Hello"
print(ham)

# You can use a slice to change the values of whatever indexes fall in the slice
ham[1:3] = ["Cat", "Dog", "Mouse"]
print(ham)


print("\n________________________________________________________________________________")


print("Slice shortcuts:")

# Animal is a list
animal = ["cat", "bat", "rat", "elephant"]
print(animal)

# The slice will start at 0 and go to but not including index 2
print(animal[:2])

# The slice will start at index 1 and go to the last index of the list
print(animal[1:])


print("\n________________________________________________________________________________")


print("Delete values from a list")

# Deletes the value inside of the index and moves all higher indexes down 1
del animal[2]
print(animal)

del animal[2]
print(animal)


print("\n________________________________________________________________________________")


print("String and list similarities:")

# Prints the length of "Hello", which is 5
print(len("Hello"))

# Prints the number of items inside of a list
print(len([1,2,3,]))

# Joins two strings together
print("Hello " + "world")

# Joins two lists together
print([1,2,3] + [4,5,6])

# String replication (multiplying string by an integer)
print("Hello" * 3)

# List replication
print([1,2,3] * 3)


print("\n________________________________________________________________________________")


print("The list() function:")

# Converts a string into an int
print(int('42'))

# Converts an int into a string
print(str(42))

# list() returns a list form to the function passed to it
# The function passed can only be a string
print(list('Hello'))


print("\n________________________________________________________________________________")


print("In and not in operators:")

# The in function will print True since "howdy" is a value in the list
print("howdy" in ['hello', 'hi', 'howdy', 'hiya'])

# The in function will print False since 42 is not a value in the list
print(42 in ['hello', 'hi', 'howdy', 'hiya'])

# The not in function will print False since "howdy" is a value in the list
print("howdy" not in ['hello', 'hi', 'howdy', 'hiya'])

# The not in function will print True since 42 is not a value in the list
print(42 not in ['hello', 'hi', 'howdy', 'hiya'])
