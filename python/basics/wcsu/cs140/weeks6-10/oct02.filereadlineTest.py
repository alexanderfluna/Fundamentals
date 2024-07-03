# file processing

def fileop():
    # opening file for writing
    myFile = open("myfile.txt", "w")
    for i in range(8):
        print("aaaaaa", file=myFile)

    #closing file
    myFile.close()
    #Opening file for reading
    rfile = open("myfile.txt","r")
    #Using readline()
    print("reading from file using read()")
    print(rfile.readline())
   

fileop()
