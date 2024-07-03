# oct19.bankaccount.py || Created by: Alexander Luna || October 19, 2020
# This program will ask the user if they want to view their current balance or if they
# want to deposit/withdraw and the amount. Then it will ouput their final balance.

balance = 100

def main():
    # Introduces program
    print('This program will ask the user if they want to view their current balance or if they')
    print('want to deposit/withdraw cash and the amount. Then it will ouput their final balance.', end='\n\n')

    # Initializes variables
    askUser = ''

    # While loop to keep prompting user
    while askUser != 'View my current balance' and askUser != 'Deposit' and askUser != 'Withdraw':
        askUser = input('Enter which option you would like to choose: View my current balance / Deposit / Withdraw ')
            
    # If else that chooses which function to run depending on the input
    if askUser == 'View my current balance':
          current(balance)
    elif askUser == 'Deposit':
          deposit(balance)
    else:
          withdraw(balance)
          
def current(balance):
    # Prints current balance
    print('Your current balance is ${0:0.2f}.'.format(balance))

    # Intializes variable
    askUser = ''

    # While loop to keep prompting user
    while askUser != 'Yes' and askUser != 'No':
        askUser = input ('Would you like to deposit or withdraw? Answer Yes or No. ')

    # If else that chooses which function to run depending on the input
    if askUser == 'Yes':
        while askUser != 'Deposit' and askUser != 'Withdraw':
            askUser = input('Enter which option you would like to choose: Deposit / Withdraw. ')
    else:
        final(balance)

    # If else that chooses which function to run depending on the input
    if askUser == 'Deposit':
        deposit(balance)
    else:
        withdraw(balance)
                         

def deposit(balance):
    # While loop to keep prompting user
    while True:
        try:
            askUser = float(input('How much would you like to deposit? '))
            
            if askUser >= 0:
                break
            else:
                continue
        except KeyboardInterrupt:
            exit()
        except:
            print('You must input a positive number.')
            continue

    # Adds the input to balance
    balance += askUser

    # While loop to keep prompting user
    while askUser != 'Yes' and askUser != 'No':
        askUser = input ('Would you like to view your current balance or withdraw? Answer Yes or No. ')

    # If else that chooses which function to run depending on the input
    if askUser == 'Yes':
        while askUser != 'View my current balance' and askUser != 'Withdraw':
            askUser = input('Enter which option you would like to choose: View my current balance / Withdraw. ')
    if askUser == 'No':
        final(balance)

    # If else that chooses which function to run depending on the input
    if askUser == 'Withdraw':
        withdraw(balance)
    else:
        current(balance)

def withdraw(balance):
    # While loop to keep prompting user
    while True:
        try:
            askUser = float(input('How much would you like to withdraw? '))

            # Avoids overdraft fee
            if askUser >= 0 and askUser <= balance:
                break
            else:
                continue
        except KeyboardInterrupt:
            exit()
        except:
            print('You must input a positive number.')
            continue
     
    # Subtracts the input from the balance         
    balance -= askUser

    # While loop to keep prompting user
    while askUser != 'Yes' and askUser != 'No':
        askUser = input ('Would you like to view your current balance or deposit? Answer Yes or No. ')

    # If else that chooses which function to run depending on the input
    if askUser == 'Yes':
        while askUser != 'View my current balance' and askUser != 'Deposit':
            askUser = input('Enter which option you would like to choose: View my current balance / Deposit ')
    if askUser == 'No':
        final(balance)

    # If else that chooses which function to run depending on the input
    if askUser == 'Deposit':
        deposit(balance)
    else:
        current(balance)

def final(balance):
    print('Your final balance is ${0:0.2f}.'.format(balance))
    exit()

main()
