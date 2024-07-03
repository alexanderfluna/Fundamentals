print("LESSON 16: SIMILARITIES BETWEEN LISTS AND STRINGS")

# Iterates through every index in name and prints out the index value")
name = 'Alex'

for letter in name:
    print(letter)

# Doesn't print a new space
name = "Alex"
for letter in name:
    print(letter, end='')

print("____________________________________________________________________")

print("MUTABLE AND IMMUTABLE DATA TYPES", end='\n\n')

print("Lists in python are mutable and can be changed.")
print("Strings in python are immutable and cannot be changed")


print("____________________________________________________________________")


print("CREATING NEW STRINGS FROM SLICES", end='\n\n')

cat = 'Zophie a cat'
print(cat)

# Creates a new variable using slices from cat & adds a new string to it
newCat = cat[0:7] + 'the' + cat[8:12]
print(newCat)


print("____________________________________________________________________")

print("REFERENCES", end='\n\n')

spam = [0, 1, 2, 3, 4, 5]
print(spam)

# Cheese is given a reference to the list spam
cheese = spam

# Changes the value of index 1 in cheese
cheese[1] = 'Hello!'
print(cheese)

# When cheese was changed, the original list spam was changed as well
print(spam)


print("____________________________________________________________________")

print("PASSING LISTS IN FUNCTION CALLS", end='\n\n')

# Cheese is a local variable in the function & would usually be eliminated after the function is over
# But, because cheese is a reference to a list, the changes made to it stay after the function ends
def eggs(cheese):
    cheese.append('Hello')

spam = [1, 2, 3]
print(spam)

eggs(spam)
print(spam)

print("____________________________________________________________________")

print("THE copy.deepcopy() FUNCTION", end='\n\n')

# Have to import copy to use .deepcopy
import copy

# Creates spam list
spam = ['A', 'B', 'C']
print(spam)

# Cheese is given a complete copy of spam instead of a reference
cheese = copy.deepcopy(spam)

# Changes the value of the first index of cheese
cheese[1] = 42
print(cheese)

# Because cheese was sent a deepcopy of spam, the changes made to cheese do not affect spam
print(spam)

print("____________________________________________________________________")

print("THE LINE CONTINUATION", end='\n\n')
# A list can be made like the below to look cleaner to a human
spam = ['apples',
        'oranges',
        'bananas',
        'cats']
print(spam)

# The \ in the code tells python that the print will continue to the next line")
print("Four score and seven" + \
      " years ago")
