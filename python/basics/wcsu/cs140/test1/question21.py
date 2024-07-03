# Test 1 - Part 3 | Question 21
#   This program will calculate the price of an item everyday for five days as 10% is reduced
# By: Alexander Luna| Student Code: 50242833| 10/30/2020

def price():
    # Prints the purpose of the program
    print('This program will calculate the price of an item everyday for five days as 10% is reduced.')

    # Initializes itemCost and weekdays
    itemCost = 0
    weekdays = ['Monday', 'Tuesday', 'Wednesday', 'Thursday', 'Friday']

    # Infinite loop
    while True:
        # Tries code below
        try:
            
            # Asks user to input price of item
            while itemCost <= 0:
                itemCost = float(input('What is the price of the item? '))
            # Breaks from loop if correct value
            break

        # Exits program
        except KeyboardInterrupt:
            return
        # Does code below if any error occurs
        except:
            print("The price must be a decimal number")
            # Starts the while loop over again
            continue
    
    # For loop to print out the price of the item on what day
    for i in range(5):
        print('The price of the item on ' + weekdays[i] + ' is ${0:0.2f}.'.format(itemCost))
        itemCost *= .90
        
price()
