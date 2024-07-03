require 'socket'

# Define the server address and port
SERVER_ADDRESS = 'localhost'
PORT = 12345

# Create a TCP socket and connect to the server
client = TCPSocket.new(SERVER_ADDRESS, PORT)

puts "Connected to server at #{SERVER_ADDRESS}:#{PORT}"

# Main loop: read input from the user and send it to the server
loop do
  # Prompt the user to enter a message
  print "Enter message to send (or 'exit' to quit): "
  message = gets.chomp

  # If the user enters 'exit', close the connection and exit the loop
  if message.downcase == 'exit'
    puts "Exiting..."
    break
  end

  # Send the message to the server
  client.puts(message)

  # Read the server's response and display it
  response = client.gets
  puts "Server response: #{response.chomp}"
end

# Close the connection
client.close
