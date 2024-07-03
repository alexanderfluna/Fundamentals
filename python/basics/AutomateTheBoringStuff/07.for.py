# Adds all numbers together from 1 - 100
total = 0
for num in range(101):
    total = total + num
print(total)

# i starts at 12 and iterates up to, but not including, 16
for i in range(12, 16):
    print("i = " + str(i))

# First two arguments are start and stop values.
# The third is is the step argument (how much to increment)
for j in range(5, -1, -1):
    print("j = " + str(j))
