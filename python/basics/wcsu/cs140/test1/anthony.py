def main():
    pricing()
    print("\n")
    txtAcro()

def pricing():
    price = round(float(input("How much?: ")) * .9, 2)
    days = ["Tuesday", "Wednesday", "Thursday", "Friday"]
    i = 0
    print("Monday: " + "$", price, sep="")
    while i < len(days):
        price = round(price * 0.9, 2)
        print(days[i] + ": $", price, sep="")
        i += 1

def txtAcro():
    inFile = open("studentList.txt", "r")
    names = inFile.read()
    splitNames = names.split("\n")
    i = 0
    while i < len(splitNames):
        acronym(splitNames[i])
        i += 1
    print("\nTotal number of students:", i)
    inFile.close()
    
def acronym(name):
    splitName = name.split()
    acroName = ""
    curName = ""
    i = 0
    while i < len(splitName):
        curName = splitName[i]
        acroName += curName[0] + '.'
        i += 1
    if len(name) < 16:
        print(name + ":\t\t" + acroName)
    else:
        print(name + ":\t" + acroName)
    
main()
