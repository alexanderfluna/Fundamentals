# This program will calculate the value of the college tuition after 10 years

def main():

    print("This program will calculate the value of the college tuition after 10 years.")


    base = eval(input("Enter the base of the current cost of tuition: "))

    interest = eval(input("Enter the interest rate as a decimal: "))


    for i in range(10):

        base = base * (1 + interest)

    print ("The value in 10 years is:", base)


main()

