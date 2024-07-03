def main():
    str1 = "This "
    str2 = "is a string."
    str3 = str1 + str2
    print (str3)

    # str3 = str1 + 4 # cannot have mixed expressions for concatenation

    # str6 = 4 + "5" # cannot
    
    print (3 * str1)

    str4 = str1 * 3
    print ("str4 is", str4)
    
    str5 = str1 * 3 * 2
    print (str5)

    str6 = "first" + 3 * " second"
    print (str6)

    str6 = "first" +  " second" * 3
    print (str6)

    #iterating through a string
    for ch in str3:
        print (ch)

    for ch in str3[ :5]:
        print (ch)
main()
