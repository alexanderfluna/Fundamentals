# This program will determine if the value input by a user is prime or not.
# By: Alexander Luna | November 9, 2020

def prime():

    # Introduces the program
    print("This program will determine if the value input by a user is prime or not.")
    
    # Infinite loop
    while True:
        
        # Tries the code below
        try:
            
            # Gets user input
            number = int(input("Enter a number: "))
            
            # Breaks or continues depending on user input
            if number < 2:
                print("The number must be a positive integer greater than 1.")
                continue
            else:
                break
            
        # Exits program
        except KeyboardInterrupt:
            return
        # Prints if user input was not an int
        except:
            print("The number must be a positive integer greater than 1.")
            continue

    # Hard-code for the prime numbers less than 10
    if number == 2 or number == 3 or number == 5 or number == 7:
        print("Your number is prime.")
        return
        
    # Hard-code for the non-prime numbers less than 10
    elif number == 4 or number == 6 or number == 8 or number == 9:
        print("Your number is not prime.")
        return
        
    # Checks if the number is divisible by another number besides 1 and itself
    elif number > 9:
        for i in range(2, 10):
            isPrime = number % i
            if isPrime == 0:
                print("Your number is not prime.")
                return

    print("Your number is prime.")
            
prime()
