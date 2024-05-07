// FileCopyErrorDemo.cs - A file copy program with excessive error handling.

using System;
using System.IO;

public class CopyApp {

  public static void Main(string[] args) {
    FileInfo inFile;
    do {
        inFile = new FileInfo(args[0]);
        if (!inFile.Exists)
          args[0] = "some other input file name";
    } while (!inFile.Exists);

    FileInfo outFile;
    do {
        outFile = new FileInfo(args[1]);
        if (outFile.Exists)
          args[1] = "some other output file name";
    } while (outFile.Exists);

    FileStream inStr   = inFile.OpenRead(),
               outStr  = outFile.OpenWrite();
    int c;
    do{
       c = inStr.ReadByte();
       if(c != -1) 
		   outStr.WriteByte((byte)c);
       if (StreamFull(outStr))
         DreamCommand("Fix some extra room on the disk");
    } while (c != -1);  

    inStr.Close();
    if (!FileClosed(inStr))
      DreamCommand("Deal with input file which cannot be closed");

    outStr.Close();
    if (!FileClosed(outStr))
      DreamCommand("Deal with output file which cannot be closed");
  }



  /* Programming pseudo commands for the sake of this example */

  public static void DreamCommand(string str){
    // Carry out the command str
  }

  public static bool FileClosed(Stream str){
    // Return if the stream str is closed
  }

  public static bool StreamFull(Stream str){
    // Return if the stream str is full
  }    

}