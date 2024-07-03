def main():
    print ("Uppercase Letters")
    capitals = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    print ("Character Encoding ")
    for ch in capitals:
        print (ch, "       ", ord(ch))

    print()
    print ("Lowercase Letters")
    lowercases = "abcdefghijklmnopqrstuvwxyz"
    print ("Character Encoding ")
    for ch in lowercases:
        print (ch, "       ", ord(ch))

    print()
    #What characters are between the uppercase and lowercase letters?
    print ("Characters with codes from 91 to 96")
    for code in range(91,97):
        print (chr(code), "        ", code)
main()
