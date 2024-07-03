# Test 2 | Question 16
#   This program will ask the user for their name, Social Security Number(SSN), and their net income.
#   Then, it will return what their name, Social Security Number(SSN), and tax is.
# Alexander Luna | 12/4/2020 | Student Code: 50242833

# Main function
def main():
    # Prints purpose of program
    print("This program will ask the user for their name, Social Security Number(SSN), and their net income.")
    print("Then, it will return what their name, Social Security Number(SSN), and tax is.", end='\n\n')
    
    # Calls getName
    name = getName()

    # Calls getIncome
    netIncome = getIncome()

    # Calls getSocial
    socialSecurity = getSocial()
    
    # Calls calculate tax
    tax = calculateTax(netIncome)

    print(f"Your name is: {name}. Your Social Security Number(SSN) is: {socialSecurity}. Your tax is: ${tax}.")

# Asks user for their name
def getName():

    # Prompts user
    name = input("What is your name? ")
    return name


# Asks user net annual income
def getIncome():

    # Infinite loop
    while True:
        
        # Tries code below
        try:
            
            # Initializes variable
            netIncome = 0
            
            # While loop to ask for netIncome
            while netIncome <= 0:
                netIncome = float(input("What is your net annual income? $"))
            return netIncome
        
        except KeyboardInterrupt:
            exit()
        except:
            print("You must type a decimal number greater than 0.")
    
def getSocial():

    # Prompts user
    socialSecurity = input("What is your Social Security Number(SSN)?: ")
    return socialSecurity

def calculateTax(netIncome):

    # Initializes tax
    tax = 0

    # Checks if tax is between what bracket and returns tax amount
    if netIncome < 15000:
        return tax
    elif netIncome < 30000:
        tax = netIncome * .05
        return tax
    else:
        tax = netIncome * .10
        return tax

main()
