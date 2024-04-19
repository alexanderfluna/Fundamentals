# Define a variable outside any function or method
$x = "Global"

# Define a method that attempts to access the variable
def method
  puts "Inside method: #{$x}"
end

# Define a block that attempts to access the variable
5.times do |i|
  puts "Inside block iteration #{i + 1}: #{$x}"
end

# Attempt to access the variable at the top level
puts "Outside method and block: #{$x}"
