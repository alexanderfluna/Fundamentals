# This program will allow users to enter student test scores, print all student test
# scores, print the average score, print the largest and lowest scores, print all
# the students with passing scores, and all the students above the class average
#                By: Alexander Luna | November 19, 2020

def main():

    testScores = []
    getScores(testScores)
    printScores(testScores)
    classAverage(testScores)
    largestScore(testScores)
    lowestScore(testScores)
    passingScores(testScores)
    aboveAverage(testScores)

def getScores(testScores):

    # Gets amount of student scores
    while True:
        try:
            amount = int(input("How many student scores will you enter? "))

            if amount >= 1:
                break
            else:
                print("You must enter a positive integer.")
                continue

        except KeyboardInterrupt:
            return
        except:
            print("You must enter a positive integer.")
            continue

    # Gets student scores
    while True:
        try:

            num = 0
                
            while num < amount:
                score = float(input("   Enter the student's score: "))

                if score >= 0 and score <= 100:
                    testScores.append(score)
                    num += 1
                else:
                    print("Your answer must be an integer or decimal number between 0-100")
                    continue

            break
            
        except KeyboardInterrupt:
            return
        except:
            print("Your answer must be an integer or decimal number between 0-100.")
            continue

def printScores(testScores):
    # Sorts list
    testScores.sort()
    print("Grades in numerical order:")

    # Prints scores
    for i in range(len(testScores)):
        print("   Grade #" + str(i+1) + ": {0:0.2f}.".format(testScores[i]))

def classAverage(testScores):
    total = 0
    
    # Adds all scores
    for i in range(len(testScores)):
        total += testScores[i]

    # Divides sum by number of scores and prints total
    total /= len(testScores)
    print("The class average score is: {0:0.2f}.".format(total))


def largestScore(testScores):
    print("The largest test score is: {0:0.2f}.".format(testScores[-1]))


def lowestScore(testScores):
    print("The lowest test score is: {0:0.2f}.".format(testScores[-0]))


def passingScores(testScores):
    print("All passing scores (>50):")
    
    passingStudents = 1

    # Prints passing students
    for i in range(len(testScores)):
        if testScores[i] >= 50:
            print(f"   #{passingStudents}: {testScores[i]}")
            passingStudents += 1

def aboveAverage(testScores):
    print("All the scores above the class average:")

    total, students = 0, 1
    # Adds all scores
    for i in range(len(testScores)):
        total += testScores[i]
    # Divides sum by number of scores and prints total
    total /= len(testScores)

    # Prints test scores above class average
    for i in range(len(testScores)):
        if testScores[i] > total:
            print("   #" + str(students) + ": {0:0.2f}.".format(testScores[i]))
            students += 1

main()
