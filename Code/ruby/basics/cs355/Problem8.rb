# Alexander Luna | Assignment 2 | Problem8.rb
# Experiment to test static or dynamic type checking in Ruby

# Define a method that takes two parameters and adds them
def add(x, y)
  puts "Result: #{x + y}"
end

# Case 1: Call the method with integer arguments
puts "Case 1: Calling the method with integer arguments"
add(5, 10)

# Case 2: Call the method with string arguments
puts "\nCase 2: Calling the method with string arguments"
begin
  add("Hello", "World")
rescue TypeError => e
  puts "Error: #{e.message}"
end

# Case 3: Call the method with one integer and one string argument
puts "\nCase 3: Calling the method with one integer and one string argument"
begin
  add(5, "World")
rescue TypeError => e
  puts "Error: #{e.message}"
end
