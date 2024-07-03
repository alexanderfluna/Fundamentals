//FileCopy1.cs - A file copy program.

using System;
using System.IO;

public class CopyApp {

  public static void Main(string[] args) {
    FileInfo   inFile  = new FileInfo(args[0]),
               outFile = new FileInfo(args[1]);
    FileStream inStr   = inFile.OpenRead(),
               outStr  = outFile.OpenWrite();
    int c;
   do{
      c = inStr.ReadByte();
      if(c != -1) outStr.WriteByte((byte)c);
   } while (c != -1);  

   inStr.Close();
   outStr.Close();
 }
}