# Assignment #1: problem3.py
# Alexander Luna
# October 14, 2020
# This program will create a file holding the names of the students in a Python class

def file():
    
    # Introduces the program
    print('This program will create a file holding the names of the students in a Python class')

    # Initializes amount
    amount = 0

    # Creates an infinite while loop
    while True:
        try:            
            # Asks user how many students names will be entered
            amount = int(input('How many names of students will you enter? '))

            # Breaks from the loop if amount >= 1
            if amount >= 1:
                break
            
            # Restarts the loop if amount < 1
            else:
                print('Your input must be a positive integer.')
                continue
        
        # Exits the program if the user does ctrl + c
        except KeyboardInterrupt:
            return
        
        # Restarts the while loop if the user did not enter an int
        except:
            print('Your input must be a positive integer.')
            continue

    # Creates pythonStudents.txt file
    newFile = open('pythonStudents.txt', 'w')

    # For loop for user to enter the names of the Python students
    for i in range(amount):
        name = input('Input the name of the student: ')
        print(name, file=newFile)

    # Closes file
    newFile.close()
    
file()
