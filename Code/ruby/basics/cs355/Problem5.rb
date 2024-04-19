# Alexander Luna | Assignment 2 | Problem5.rb

# Define a variable outside any function
value = 0

# Case 1: Access the variable at the top level
puts "Case 1: Access the variable at the top level\nThe value is #{value}"

# Case 2: Define a loop to access the variable
puts "\nCase 2: Define a loop to access the variable\n"
4.times do |i|
  value += 1
  puts "The value is #{value}"
end

# Case 3: Define a conditional to access the variable
puts "\nCase 3: Define a conditional to access the variable\n"
if value < 5
  puts "#{value} is less than 5"
elsif value > 5
  puts "#{value} is greater than 5"
else
  puts "The value is #{value}"
end

# Case 4: Define a method that attempts to access the local variable
puts "\nCase 4: Define a method that attempts to access the variable\n"
def method1
  # Uncommenting the line belows gives us the error:
  # undefined local variable or method `value' for main:Object (NameError)

  # puts "\nInside method1: #{value}"
end
method1

# Case 5: Define methods to access a global variable
puts "\nCase 5: Define methods to access a global variable"
$global_variable = "hello"
def method2
  puts "Inside method2: #{$global_variable}"
  $global_variable += " world"

  def method3
    puts "Inside method3: #{$global_variable}"
  end
end
method2
method3
