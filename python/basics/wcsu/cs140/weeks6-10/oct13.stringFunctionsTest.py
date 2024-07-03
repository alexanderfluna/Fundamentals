import string
def main():
    str1 = "hello, i came here for an argument"
    print (str1.upper())
    str2 = str1.replace( "i","You")
    print (str2)
    # Prints how many "e" are in the string
    print(str.count('e'))
    # Prints the index of the first "e" in the string
    print(str.find('e'))
    
main()
