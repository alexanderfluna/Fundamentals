# Test 1 - Part 3 | Question 22
#   This program will read the student's names from the file and display the student's names
#   and their initials. Then it will print out the number of students in the class.
# By: Alexander Luna| Student Code: 50242833| 10/30/2020

def name():
    # Print the purpose of the program
    print("This program will read the student's names from the file and display the student's names and their initials. Then it will print out the number of students in the class.", end = '\n\n')

    # Initializes studentNames
    studentNames = []

    # Opens file to read
    rfile = open("studentList.txt", "r")

    # Puts names into studentNames
    for name in rfile.readlines():
        studentNames.append(name.split())

    # Print out names and initials
    for i in range(len(studentNames)):
        # First name
        print(studentNames[i][0], end = ' ')
        # Last name
        print(studentNames[i][1], end = ' ')
        # First initial
        print(studentNames[i][0][0], end = '')
        # Last initial
        print(studentNames[i][1][0])

    # studentAmount = Number of students in class
    studentAmount = len(studentNames)

    # Prints number of students in class
    print('The number of students in the class is ' + str(studentAmount))

    # Closes file
    rfile.close()       
    
name()
