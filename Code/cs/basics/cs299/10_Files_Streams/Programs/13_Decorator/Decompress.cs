// Decompress.cs - The corresponding program that decompresses the file. 


using System;
using System.IO;
using System.IO.Compression;

public class CompressProg{

  public static void Main(string[] args){
    byte[] buffer;
    int LargeEnough = 10000;
  
    GZipStream compressedzipStream = 
       new GZipStream( 
         new BufferedStream(
                new FileStream(
                      args[0], FileMode.Open),
                128),
         CompressionMode.Decompress);

    buffer = new byte[LargeEnough];
    
    // Read and decompress the compressed stream:
    int bytesRead = 0,
        bufferPtr = 0;
    do{
      // Read chunks of 10 bytes per call of Read:
      bytesRead = compressedzipStream.Read(buffer, bufferPtr, 10); 
      if (bytesRead != 0) bufferPtr += bytesRead;
    } while (bytesRead != 0);

    compressedzipStream.Close();

    // Write contens of buffer to the output file
    using(Stream outfile = new FileStream(args[1], FileMode.Create)){
       outfile.Write(buffer, 0, bufferPtr);
    }
  }

}

