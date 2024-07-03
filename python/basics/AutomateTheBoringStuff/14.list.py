print("Lesson 14: |for Loops with Lists| Multiple Assignment| Augmented Assignment Operators")
print("\n")

print("Range objects and list-like values:")

# Returns a value type called a range object, which is list-like (sequences)
print(range(4))


print("\n")


print("The list() function:")

# Converts range(4) to a list
print(list(range(4)))

# To make a large list of integers, the range function can be used
print(list(range(0, 100, 5)))


print("\n")


print("For loop:")

# For loop that uses the length of supplies to prints every item inside of it
supplies = ['pens', 'staplers', 'flame-throwers', 'binders']
for i in range(len(supplies)):
    print('Index ' + str(i) + ' in supplies is: ' + supplies[i])


print("\n")


print("Multiple assignment:")

# Cat is a list
cat = ['fat', 'orange', 'loud']

# Size is set to cat[0], color to cat[1], disposition to cat[2]
size, color, disposition = cat
print(size, color, disposition)

# Assign multiple variables to multiple values at once
size, color, disposition = 'skinny', 'black', 'quiet'
print(size, color, disposition)


print("\n")


print("Swapping Variables:")

a = 'AAA'
b = 'BBB'
print(a, b)

# Swaps the variables
a, b = b, a
print(a, b)


print("\n")


print("Augmented Assignment Operators:")

spam = 42
print(spam)
# Add 1
spam += 1
print(spam)
# Sub 1
spam -=1
print(spam)
# Mult 1
spam *= 1
print(spam)
# Div 1
spam /= 1
print(spam)
# % 1
spam %= 1
print(spam)
