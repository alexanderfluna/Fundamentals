using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Server
{
    static void Main()
    {
        // Set the IP address and port number
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        int port = 12345;

        // Create a TCP listener
        TcpListener listener = new TcpListener(ipAddress, port);
        listener.Start();

        Console.WriteLine("Server is waiting for a connection...");

        // Accept a client connection
        TcpClient client = listener.AcceptTcpClient();
        Console.WriteLine("Client connected!");

        // Get the client's network stream
        NetworkStream stream = client.GetStream();

        // Send and receive data
        byte[] data = new byte[256];
        int bytesRead;

        while (true)
        {
            // Receive data from the client
            bytesRead = stream.Read(data, 0, data.Length);
            string receivedData = Encoding.ASCII.GetString(data, 0, bytesRead);
            Console.WriteLine($"Received: {receivedData}");

            // Send a response back to the client
            string responseData = "Message received by the server.";
            byte[] responseBytes = Encoding.ASCII.GetBytes(responseData);
            stream.Write(responseBytes, 0, responseBytes.Length);
        }

        // Close the listener and client
        listener.Stop();
        client.Close();
    }
}
