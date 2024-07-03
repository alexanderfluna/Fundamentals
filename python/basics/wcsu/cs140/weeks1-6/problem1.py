# This program will calculate the total of the sequence in problem 1

def main():
    print("This program will calculate the total of the sequence in problem 1")

    total = 0
    const = eval(input("Enter the value of const: "))
    num = eval(input("Enter the number of items in the sequence to be added: "))

    for i in range(num):
        const = const + ((2+i)/(3+2*i))
    
    print(const)

main()
