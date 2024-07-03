# Final Exam | Question 17
#   This program will display student's last names, test scores, average class score, largest
#   score in class, lowest score in class, all pass scores, all scores above class average
#   and the median of entered scores.
# Alexander Luna | 12/10/2020 | Student Code: 50242833

def main():
    print("This program will display student's last names, test scores, average class score, largest")
    print("score in class, lowest score in class, all pass scores, all scores above class average")
    print("and the median of entered scores.", end='\n\n')
    lastName, testScore, newFile = getData()
    printData(newFile)
    testScore.sort()
    calculateAverage(testScore)
    largestScore(testScore)
    lowestScore(testScore)
    passingScores(lastName, testScore)
    aboveAverage(lastName, testScore)
    medianScore(testScore)

def getData():
    lastName, testScore = [], []
    namePrompt, scorePrompt = '.', -1
    
    newFile = open('StudentData.txt', 'w')

    while namePrompt != '':
        namePrompt = input("Enter the students' last name (Press enter to stop): ")
        if namePrompt != '':
            lastName.append(namePrompt)

    while True:
        try:
            for i in range(len(lastName)):
                scorePrompt = -1
                while scorePrompt < 0 or scorePrompt > 100:
                    scorePrompt = float(input(f"What is {lastName[i]}'s test score: "))
                    if scorePrompt >= 0 and scorePrompt <= 100:
                        testScore.append(scorePrompt)
                        print(lastName[i], file=newFile, end=' ')
                        print(testScore[i], file=newFile)
                    else:
                        print("You must type in numbers ranging from 0-100.")
                        testScore = []
                        continue
            newFile.close()
            return lastName, testScore, newFile
        except:
            print("You must type in numbers ranging from 0-100.")
            testScore = []
            continue

def printData(newFile):
    print("Student's last names & scores:")
    rfile = open('StudentData.txt', 'r')
    for line in rfile.readlines():
        print(line)

def calculateAverage(testScore):
    total = 0

    for i in range(len(testScore)):
        total += testScore[i]

    total /= len(testScore)
    print(f"The class average score is: {total:.2f}.")

def largestScore(testScore):
    print("The largest test score is: {0:0.2f}.".format(testScore[-1]))

def lowestScore(testScore):
    print("The lowest test score is: {0:0.2f}.".format(testScore[-0]))

def passingScores(lastName, testScore):
    print("All passing scores (>50):")
    passingScore = 1
    for i in range(len(testScore)):
        if testScore[i] >= 50:
            print(f"{lastName[i]}: {testScore[i]}")
            passingScore += 1

def aboveAverage(lastName, testScore):
    print("All the scores above the class average:")
    total, students = 0, 1
    for i in range(len(testScore)):
        total += testScore[i]
    total /= len(testScore)

    for i in range(len(testScore)):
        if testScore[i] > total:
            print(f"{lastName[i]}: {testScore[i]}.")

def medianScore(testScore):
    if len(testScore) % 2 == 0:
        median1 = testScore[len(testScore)//2]
        median2 = testScore[len(testScore)//2 - 1]
        median = (median1 + median2)/2
    else:
        median = testScore[(len(testScore)//2)]

    print(f"The median is: {median}")
    
main()
