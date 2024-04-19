# Alexander Luna | Assignment 2 | Problem4.rb

$x = "Global"  # Global variable

def method
  $x = "Method"  # Method-scoped variable
  puts "Inside method: #{$x}"
end

method  # Call the method

puts "Outside method: #{$x}"  # Print the global variable

# Loop body
puts "Loop body:"
5.times do |i|
  $x = "Loop"  # Loop-scoped variable
  puts "Inside loop iteration #{i + 1}: #{$x}"
end

puts "Outside loop: #{$x}"  # Print the updated global variable

# Compound statement
puts "Compound statement:"
if true
  $x = "If"
  puts "Inside if: #{$x}"
end

puts "Outside if: #{$x}"  # Print the updated global variable

# Nested blocks
puts "Nested blocks:"
def outer_method
  $x = "Outer Method"
  puts "Inside outer method: #{$x}"

  # Nested method
  def inner_method
    $x = "Inner Method"
    puts "Inside inner method: #{$x}"
  end

  inner_method  # Call the inner method
  puts "After inner method: #{$x}"  # Print the updated global variable
end

outer_method  # Call the outer method
puts "Outside outer method: #{$x}"  # Print the updated global variable
