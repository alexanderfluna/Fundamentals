# imports modules to use their functions
import random, sys, os, math

# built-in functions of python
print()
input()
len()

# randint isn't a built-in function of python..
# it is a function from the random module..
# that's why it needs 'random.' before it.
random.randint(1, 10)

# imports and calls all functions from a module
from random import *
# you do not need to call 'random.' because the line above does that..
# however, doing 'random.randint' is better because it's more readable.
randint(1, 10)

# terminates the function early
sys.exit
# goodbye is not printed because of the above line
print("Goodbye")
