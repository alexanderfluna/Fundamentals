print("LESSON 17: THE DICTIONARY DATA TYPE", end ='\n\n')

#Like a list, a dictionary is a collection of many values
#But unlike list indexes, indexes for dictionaries can use many different data types
#Indexes for dictionaries are called keys and a key with its associated value is called a key value pair
# A good way to think about dictionaries is that with an actual dictionary, if you know the word then you can get the defintiion...
# In a dictionary in python, if you know the key(word) then you can get the value(definition).


print("___________________________________________________________________________")


print("Key-Value Pairs:", end ='\n\n')
      
# A dictionary is typed with curly braces. Inside the curly braces are
# There can be multiple key-value pairs when separated by commas
# The keys are size, color, disposition. The values are fat, gray, loud.
myCat = {'size' : 'fat', 'color': 'gray', 'disposition': 'loud'}

# This will go to the index(key) of myCat at 'size', which has a value of 'fat'
print(myCat['size'])

# The value of a dictionary can be concatenated into a string
print("My cat has " + myCat['color'] + " fur.")

spam = {12345: 'Luggage combination', 42: 'The Answer'}


print("___________________________________________________________________________")


print("Dictionaries are unordered:", end ='\n\n')

# spam[0] will be the first item in a list, but there is no first item in a dictionary

# This will not work because lists are ordered and the order matters
print([1, 2, 3] == [3, 2, 1])

eggs = {'name': 'Zophie', 'species': 'cat', 'age': 8}
ham = {'species': 'cat', 'name': 'Zophie', 'age': 8}

# This will work because dictionaries have no order
print(eggs == ham)


print("___________________________________________________________________________")


print("KeyError:", end ='\n\n')

# Trying to get a key that doesn't exist in the dictionary will result in this error
# print(eggs['color']) will not work because eggs was not given the key 'color'


print("___________________________________________________________________________")


print("in & not in:", end ='\n\n')

# Prints true since the key 'name' is in the dict eggs
print('name' in eggs)
# Prints false since the key 'name' is in the dict eggs
print('name' not in eggs)


print("___________________________________________________________________________")


print("The keys(), values(), and items() Dictionary Methods:", end ='\n\n')

# THE BELOW WILL RETURN LIST-LIKE DATA TYPES

# Will print all the keys in the dict eggs
print(list(eggs.keys()))
# Will print all the values in the dict eggs
print(list(eggs.values()))
# Returns a list of two item tuples of the key for the first term and the value as the second item
print(list(eggs.items()))

# Returns a dict_keys
print(eggs.keys())
print

# For loop to print all keys in dictionary
for k in eggs.keys():
    print(k, end=' ')

for v in eggs.values():
    print(v, end='  ')

for k, v in eggs.items():
    print(k, v, end='  ')

for i in eggs.items():
    print(i, end='  ')
print('\n')
# Typles are the exam same things as lists except they're immutable and they use parentheses instead of square brackets

# Checks if 'cat' is a value in the dict eggs
print('cat' in eggs.values())


print("___________________________________________________________________________")


print("The get() Dictionary Method:", end ='\n\n')

# More verbose way of seeing if color is a value in eggs
if 'color' in eggs:
    print(eggs['color'])

# Gets the value for the key 'age'. If there is no value, print 0.
print(eggs.get('age', 0))
# Since there is no key 'color', '' will be printed
print(eggs.get('color', 'Empty'))

picnicItems = {'apples': 5, 'cups': 2}
print('I am bringing ' + str(picnicItems.get('napkins', 0)) + ' napkins to the picnic.')


print("___________________________________________________________________________")


print("The setdefault() Dictionary Method:", end ='\n\n')

# More verbose way of adding a new key & value to dict
# Only works if the key does not already have a value
if 'color' not in eggs:
    eggs['color'] = 'black'
print(eggs)

# One line of code to add a new key & value to dict
# Only works if the key does not already have a value
eggs.setdefault('shape', 'big')
print(eggs)


print("___________________________________________________________________________")

# Pretty print module
import pprint

print("Character Counting Programing Example:", end ='\n\n')

# The ''' will allow for sentences with ' or '' to be contained in one string
message = '''It was a bright cold day in April, and the clocks were striking thirteen.'''
count = {}

# For loops can be used on string like this because strings are a list-like value
# What this does is set char = 0 & starts at the first index(letter) in the string & increments up by 1
for char in message.upper():
    # For whatever letter there is, start it at 0
    count.setdefault(char, 0)
    # Adds 1 whenever it sees the letter again
    count[char] = count[char] + 1

# Much nicer looking output as a column
pprint.pprint(count)

# As a string instead
rjtext = pprint.pformat(count)
print(rjtext)
