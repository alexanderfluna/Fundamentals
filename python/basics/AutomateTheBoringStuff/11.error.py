def div42by(divideBy):
    # Try will try the code below
    try:
        return 42 / divideBy
    # Except will do the code below if it runs across this specific error
    except ZeroDivisionError:
        print("Error: You tried to divide by zero.")

print(div42by(2))
print(div42by(12))
print(div42by(0))
print(div42by(1))

print("How many cats do you have?")
numCats = input()
try:
    if int(numCats) >= 4:
        print("That is a lot of cats.")
    elif int(numCats) < 4 and int(numCats) > 0:
        print("That is not that many cats.")
    elif int(numCats) == 0:
        print("You should buy a cat.")
    else:
        print("You cannot have negative cats.")
# Except here will print the below for any errors that occur
except:
    print("You did not enter an integer.")
