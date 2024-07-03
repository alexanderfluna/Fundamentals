# Assignment #1: problem1.py
# Alexander Luna
# October 14, 2020
# This program will find the average of a sequence of a series of numbers entered by the user.

def average():
    
    # Introduces the program
    print('This program will find the average of a sequence of a series of numbers entered by the user.')

    # Creates the variables needed for the program
    amount, num, total = 0, 0, 0

    # Creates an infinite while loop
    while True:
        try:
            # Asks the user how many numbers there are
            amount = int(input('How many numbers will you enter? '))

            # Breaks from the loop if amount >= 1
            if amount >= 1:
                break
            
            # Restarts the loop if amount < 1
            else:
                print(f'Your input must be a positive integer.')
                continue
        
        # Exits the program if the user does ctrl + c
        except KeyboardInterrupt:
            return
        
        # Restarts the while loop if the user did not enter an int
        except:
            print('Your input must be a positive integer.')
            continue
    
    # Creates an infinite while loop
    while True:
        try:
            # Gets numbers from user and appends them to num list
            for i in range(amount):
                num = eval(input('Enter a number: '))
                total += num
            break

        # Exits the program if the user does ctrl + c
        except KeyboardInterrupt:
            return

        # Restarts the while loop if the user did not enter a number
        except:
            print(f"Your inputs must be numbers.")
            total = 0
            continue

    # Divides the sum of the numbers by the amount of values
    total /= amount
    
    # Prints the answer to the second decimal point
    print('The average of the sequence of numbers you entered is: {0:0.2f}'.format(total)) 

        
average()
