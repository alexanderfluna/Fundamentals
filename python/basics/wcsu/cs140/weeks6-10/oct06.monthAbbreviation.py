def main():
    print ("This program converts a month number to month abbreviation.")
    print()

    # get the month number
    num = eval(input("Enter month number: "))
    monthString = "JanFenMarAprMayJunJulAugSepOctNovDec"
    print ("The month abbreviation is", monthString[num*3-3:num*3])

    

main()
