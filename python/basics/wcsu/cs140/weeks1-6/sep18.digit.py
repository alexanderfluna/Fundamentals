def main():
    # Introduces program
    print("This program will ask the user for a 4-digit number.")
    print("Then, it will list the digits in order and in reverse.\n")

    #Asks user for input
    order = input("Type a four digit integer: ")

    #Types list in order
    print("List in order:")
    for i in range(len(order)):
        print(f"{order[i]}")

    #Types list in reverse
    print("List in reverse:")
    reverse = order [::-1]
    for i in range(len(reverse)):
        print(f"{reverse[i]}")

        
main()
