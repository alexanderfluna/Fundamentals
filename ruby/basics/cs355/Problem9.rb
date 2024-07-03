# Alexander Luna | Assignment 2 | Problem9.rb

# Define a method with two formal parameters
def my_method(num, str)
  puts "Formal parameters: #{num}, #{str}"
end

# Call the method with correct number and types of parameters
puts "Case 1:\nCalling the method with correct number and types of parameters:"
my_method(1, "hello")

# Call the method with incorrect types of parameters
puts "\nCase 2:\nCalling the method with incorrect types of parameters:"
begin
  my_method("hello", 1)
end

# Call the method with incorrect number of parameters (too few)
puts "\nCase 3:\nCalling the method with too few parameters:"
begin
  my_method(1)
rescue ArgumentError => e
  puts "Error: #{e.message}"
end

# Call the method with incorrect number of parameters (too few)
puts "\nCase 4:\nCalling the method with too few parameters:"
begin
  my_method("hello")
rescue ArgumentError => e
  puts "Error: #{e.message}"
end

# Call the method with incorrect number of parameters (too many)
puts "\nCase 5:\nCalling the method with too many parameters:"
begin
  my_method(1, "hello", false)
rescue ArgumentError => e
  puts "Error: #{e.message}"
end
