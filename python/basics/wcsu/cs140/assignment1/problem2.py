# Assignment #1: problem2.py
# Alexander Luna
# October 14, 2020
# This program calculates the average word length in a sentence entered by the user

def length():

    # Introduces the program
    print("This program calculates the average word length in a sentence entered by the user.")

    # Initializes count, char & total
    count, char, total = [], 0, 0
    
    # Gets sentence from user
    str1 = input('Input a sentence: ')
    
    # Converts string to uppercase
    str1 = str1.upper()
    
    # Converts string into a list
    str1 = str1.split()

    # Iterates through every element in the list
    for i in range(len(str1)):
        
        # Iterates through every value in each element
        for j in range(len(str1[i])):
            
            # Checks if the value is a character
            if str1[i][j] >= 'A' and str1[i][j] <= 'Z':
                
                # If it is a character, char increases by 1
                char += 1
                
        # Excludes numbers from getting appended to list
        if char != 0:

            # Char is appended to the end of the count list
            count.append(char)
            
        # Char is reset back to 0
        char = 0

    # Adds all of the elements in the count list
    for i in range(len(count)):
        total += count[i]
        
    # Prevent ZeroDivisionError
    if len(count) != 0:
        # The total is divided by the amount of elements in count
        total /= len(count)

    # Prints out the average length of the sentence
    print("The average word length of your sentence is: {0:0.2f}".format(total))
    
length()
