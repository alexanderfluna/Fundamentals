require 'socket'

# Define the port on which the server will listen
PORT = 12345

# Create a TCP server socket
server = TCPServer.new(PORT)

puts "Server started and listening on port #{PORT}"

# Main loop: wait for connections and handle them
loop do
  # Wait for a client to connect
  client = server.accept

  # Client connected, get its address
  client_address = client.peeraddr[2]

  puts "Connection established with client at #{client_address}"

  # Handle client messages
  loop do
    # Read a line of input from the client
    input = client.gets

    # If the client sends an empty message or disconnects, stop handling messages
    break if input.nil? || input.chomp.empty?

    # Echo back the received message to the client
    client.puts "Server received: #{input.chomp}"
  end

  puts "Connection with client at #{client_address} closed"
  client.close
end
