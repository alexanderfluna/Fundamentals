# Assignment #2 | Problem 1
#   This program will ask the user for a starting number and then
#   print the Syracuse sequence for that starting number.
# By: Alexander Luna | November 20, 2020

# Main function that calls the other functions of the program
def main():

    # Functions are called
    startingNumber = getNumber()
    syracuseSequence(startingNumber)

# Function to get a starting number from the user
def getNumber():
    
    # Infinite loop
    while True:

        # Tries code below first
        try:

            # Initializes variable
            startingNumber = 0

            # Gets user input until a positive integer is entered
            while startingNumber <= 0:
                startingNumber = int(input("Enter a positive integer for the Syracuse sequence: "))

            # Returns variable when positive integer is entered
            return startingNumber

        # Exits the program for the error KeyboardInterrupt
        except KeyboardInterrupt:
            exit()
            
        # Restarts while loop for any other errors
        except:
            continue

# Function to use the starting number to print the Syracuse sequence for it
def syracuseSequence(startingNumber):
    
    # Does code below until variable == 1
    while startingNumber != 1:
        
        # If variable is even
        if startingNumber % 2 == 0:
            print(startingNumber, end=", ")
            startingNumber /= 2

        # If variable is odd
        elif startingNumber % 2 == 1:
            print(startingNumber, end=", ")
            startingNumber = 3 * startingNumber + 1

    print("1.0")
    
main()
