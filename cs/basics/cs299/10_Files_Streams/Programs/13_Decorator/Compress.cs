//Compress.cs - A program that compresses a file. 

using System;
using System.IO;
using System.IO.Compression;

public class CompressProg{

  public static void Main(string[] args){
    byte[] buffer;
    long originalLength;
  
    // Read a file, arg[0], into buffer
    using(Stream infile = new FileStream(args[0], FileMode.Open)){
       buffer = new byte[infile.Length];     
       infile.Read(buffer, 0, buffer.Length);
       originalLength = infile.Length;
    }

    // Compress buffer to a GZipStream
    GZipStream compressedzipStream = 
       new GZipStream(
          new BufferedStream( 
                  new FileStream(
                        args[1], FileMode.Create),
                  128),
          CompressionMode.Compress);
    compressedzipStream.Write(buffer, 0, buffer.Length);
    compressedzipStream.Close();

    // Report compression rate:
    Console.WriteLine("CompressionRate: {0}/{1}", 
                       MeasureFileLength(args[1]),
                       originalLength);

  }

  public static long MeasureFileLength(string fileName){
    using(Stream infile = new FileStream(fileName, FileMode.Open))
      return infile.Length;
  }

}

/*
> compress compress.cs out
CompressionRate: 545/1126
*/