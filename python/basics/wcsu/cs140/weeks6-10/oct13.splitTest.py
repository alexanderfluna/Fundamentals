
def main():
    result = "72 101 108 108 111".split()
    print (result)
    result = "72,101,108,108,111".split( ",")
    print (result)
    print (type(result))
    print (type(result[2])) # type is str
    # if I need numbers, must convert
    # can convert using eval(), or int(), or float()
    for str1 in result:
        print (eval(str1), ' ')

    print()

    for str1 in result:
        print (int(str1), ' ')

    print()
        
    for str1 in result:
        print (float(str1), ' ')

    print()
    
    for str1 in result:
        print (chr(eval(str1)))
    
    print()
    
main()
