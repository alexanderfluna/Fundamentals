# Final Exam | Question 16
#   This program will return the cell phone bill of a user.
# Alexander Luna | 12/10/2020 | Student Code: 50242833

def main():

    print("This program will return the cell phone bill of a user.", end='\n\n')
    
    accountNumber, serviceCode, morningMinutes, nightMinutes = getData()

    amountDue = billCalculations(serviceCode, morningMinutes, nightMinutes)

    print(f"Your account number is: {accountNumber}.")

    if serviceCode == 1:
        print(f"The number of minutes the telephone service was used: {morningMinutes}.")
    else:
        morningMinutes += nightMinutes
        print(f"The number of minutes the telephone service was used: {morningMinutes}.")

    if serviceCode == 1:
        serviceCode = 'regular'
    else:
        serviceCode = 'premium'
        
    print(f"Your type of service: {serviceCode}.")

    print(f"The amount due is: ${amountDue:.2f}.")

def getData():
    while True:
        try:
            accountNumber, serviceCode, morningMinutes, nightMinutes = 0, 0, -1, -1
            
            while accountNumber <= 0:
                accountNumber = int(input("Enter your account number: "))
                
            while serviceCode != 1 and serviceCode != 2:
                print("Enter your service code.")
                serviceCode = int(input("Enter 1 for regular service or 2 for premium service: "))

            if serviceCode == 1:
                while morningMinutes < 0:
                    morningMinutes = int(input("How many minutes did you use on calls? ")) 
            else:
                while morningMinutes < 0:
                    morningMinutes = int(input("How many minutes did you use on calls from 6:00am to 6:00pm? "))

                while nightMinutes < 0: 
                    nightMinutes = int(input("How many minutes did you use on calls from 6:00pm to 6:00am? "))    

            return accountNumber, serviceCode, morningMinutes, nightMinutes
        
        except:
            continue

def billCalculations(serviceCode, morningMinutes, nightMinutes):
    amountDue = 0
    
    if serviceCode == 1:
        if morningMinutes > 50:
            morningMinutes -= 50
            amountDue += morningMinutes * .20
            amountDue += morningMinutes + 10
        else:
            amountDue = 10
        return amountDue
            
    else:
        if morningMinutes > 75:
            morningMinutes -= 75
            amountDue += morningMinutes * .10
            
        if nightMinutes > 100:
            nightMinutes -= 100
            amountDue += nightMinutes * .05
            
        if amountDue >= 0:
            return amountDue

        
main()
