# This is a guess the number game.

# Imports random module for randint
import random

# Asks user what their name is and prints that they have to guess an integer 1-20
name = input("Hello. What is your name?\n")
print("Well, " + name + ", I am thinking of an integer between 1 and 20.")

# The randint function sets secretNumber = a random number
secretNumber = random.randint(1, 20)

# For loop that does the code below 6 times
for guessesTaken in range(1, 7):
    
    # Will try the code below unless there is an error 
    try:
        # Initially sets guess = 1 after every iteration
        guess = 0
        
        while guess < 1 or guess > 20:
            guess = int(input("Type a guess of an integer between 1 and 20: "))
        
    # Will do the code below if there is an error
    except ValueError:
        print("Your guess must be an integer. The program will exit if you do not.")
        while guess < 1 or guess > 20:
            guess = int(input("Type a guess of an integer between 1 and 20: "))

    if guess < secretNumber:
        print("Your guess is too low.")
    elif guess > secretNumber:
        print("Your guess is too high")
    else:
        break # This condition is for the correct guess!

if guess == secretNumber:
    print("Good job," + name + "! You guessed my number in " + str(guessesTaken) + " guesses!")
else:
    print("Nope. The number I was thinking of was " + str(secretNumber) + ".")
