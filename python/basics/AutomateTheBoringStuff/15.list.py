print("LESSON 15: LIST METHODS", end='\n\n')
print("____________________________________________________________________")


print("THE index() LIST METHOD:", end='\n\n')

# spam is a list
spam = ['cat', 'Dog', 'bat', 'cat', 'Bat']

# .index returns the index of the argument the first time it sees that value in the list
print(spam.index('cat'))

print("____________________________________________________________________")


print("THE append() AND insert() LIST METHODS:", end='\n\n')

# .append adds the argument to the end of the list
spam.append('moose')

# .insert will insert the argument at whatever index specificed
spam.insert(1, 'chicken')

print(spam)

print("____________________________________________________________________")


print("THE remove() LIST METHOD:", end='\n\n')

# .remove will remove the argument from the list the first time it sees that value in the list
# This differs from dif because dif is used to remove an index of a list
# whereas .remove is used to remove a value from a list
spam.remove('bat')
print(spam)

print("____________________________________________________________________")


print("THE sort() LIST METHOD:", end='\n\n')

num = [2, 5, 3.14, 1, -7]
print(num)

# .sort sorts a list in numerical and/or alphabetical order
num.sort()
spam.sort()

# Print multiple variables
print(num, spam)

# .sort(reverse=True) sorts a list in reverse
num.sort(reverse=True)
spam.sort(reverse=True)
print(num, spam)

# .sort cannot sort lists that have both ints and strings

print("____________________________________________________________________")


print("ASCII-BETICAL ORDER:", end='\n\n')

alph = ['a', 'z', 'A', 'Z']
print(alph)

# .sort sorts based on ASCII: Uppercase comes before lowercase
alph.sort()
print(alph)

# .sort(key=str.lower) will sort in true alphabetical order
alph.sort(key=str.lower)
print(alph)
