# Assignment #2 | Problem 2
#   This program will ask the user for what nth value of the Fibonacci sequence they want to
#   see. Then, it will print the nth value & the sum of all Fibonacci numbers in the range 1-N
# By: Alexander Luna | November 20, 2020 

# Main function that calls the other functions of the program
def main():
    nthValue = getNumber()
    fibonacciSequence(nthValue)

# Function to ask user for what nth value of the Fibonacci sequence they want to see
def getNumber():
    
    # Infinite loop
    while True:

        # Tries code below first
        try:

            # Initializes variable
            nthValue = 0

            # Gets user input until a positive integer is entered
            while nthValue <= 0:
                nthValue = int(input("Enter a positive integer to get the Nth Fibonacci number: "))

            # Returns variable when positive integer is entered
            return nthValue

        # Exits the program for the error KeyboardInterrupt
        except KeyboardInterrupt:
            exit()
        # Restarts while loop
        except:
            continue

# Function to use the number inputted to print that nth value of the Fibonacci sequence
# and to print the sum of all Fibonacci numbers in the range 1-N
def fibonacciSequence(nthValue):

    # Initializes variables
    fibonacciNumber = [1, 1]
    appendingNumber, total = 0, 0

    # Do for loop until reaching nthValue
    for i in range(nthValue):
        
        # Appends the sum of the previous two numbers in the sequence
        appendingNumber = fibonacciNumber[i] + fibonacciNumber[i+1]
        fibonacciNumber.append(appendingNumber)

        # Adds all variables in list to itself
        total += fibonacciNumber[i]

    # Prints [-3] because there were already two variables in the list
    print(f"The Nth Fibonacci number is: {fibonacciNumber[-3]}")

    # Prints all Fibonacci numbers in the range 1 - N
    print(f"The sum of the all Fibonacci numbers in the range 1 – N: {total}.")
    
main()
