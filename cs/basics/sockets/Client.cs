using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

class Client
{
    static void Main()
    {
        // Set the IP address and port number
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        int port = 12345;

        // Create a TCP client
        TcpClient client = new TcpClient();

        // Connect to the server
        client.Connect(ipAddress, port);
        Console.WriteLine("Connected to the server!");

        // Get the client's network stream
        NetworkStream stream = client.GetStream();

        // Send and receive data
        while (true)
        {
            // Get user input
            Console.Write("Enter a message: ");
            string message = Console.ReadLine();

            // Send the message to the server
            byte[] data = Encoding.ASCII.GetBytes(message);
            stream.Write(data, 0, data.Length);

            // Receive the server's response
            data = new byte[256];
            int bytesRead = stream.Read(data, 0, data.Length);
            string responseData = Encoding.ASCII.GetString(data, 0, bytesRead);
            Console.WriteLine($"Server response: {responseData}");
        }

        // Close the client
        client.Close();
    }
}
