def main():

    word = "university"
    print ("The original word is", word)
    
    #use the accumulator pattern
    #start with an empty accumulator
    newWord = ""
    
    print()
    print ("Test output")
    
    for ch in word:
        print (ch, " ",)
        code = ord(ch)
        difference = code - ord('a')
        print (difference, "\t" ,) 
        newCode = ord('A') + difference
        newChar = chr(newCode)
        print (newChar)
        # add one character at a time to the accumulator
        newWord = newWord + newChar

    print ("End of the test output")
    print()
    
    print ("The capiatalized word is", newWord)
        
    
        
main()
