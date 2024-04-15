# Creating an array using Array literal notation
array_literal = [1, 2, 3, 4, 5]

# Creating an array using the Array.new method with a size argument
array_new_with_size = Array.new(5)  # Creates an array with 5 nil elements

# Creating an array using the Array.new method with a block
array_new_with_block = Array.new(3) { |index| index + 1 }  # Creates an array with elements [1, 2, 3]

# Creating an array using the %w{} notation for an array of strings
array_of_strings = %w{apple banana orange}

# Displaying arrays created by various methods
puts "Array created using Array literal notation: #{array_literal.inspect}"
puts "Array created using Array.new with size argument: #{array_new_with_size.inspect}"
puts "Array created using Array.new with a block: #{array_new_with_block.inspect}"
puts "Array of strings created using %w{} notation: #{array_of_strings.inspect}"
puts ""

# Rest of the program remains the same as before...

# Accessing elements by index
puts "Accessing elements by index:"
puts "First element: #{array_literal[0]}"
puts "Second element: #{array_literal[1]}"
puts "Last element: #{array_literal[-1]}"
puts ""

# Iterating through an array
puts "Iterating through an array:"
array_literal.each do |element|
  puts element
end
puts ""

# Adding elements to the end of an array
puts "Adding elements to the end of an array:"
array_literal << 6
array_literal.push(7, 8)
puts array_literal.inspect
puts ""

# Removing elements from the end of an array
puts "Removing elements from the end of an array:"
array_literal.pop(2)
puts array_literal.inspect
puts ""

# Adding elements to the beginning of an array
puts "Adding elements to the beginning of an array:"
array_literal.unshift(0)
puts array_literal.inspect
puts ""

# Removing elements from the beginning of an array
puts "Removing elements from the beginning of an array:"
array_literal.shift(2)
puts array_literal.inspect
puts ""

# Finding the index of an element
puts "Finding the index of an element:"
index = array_literal.index(3)
puts "Index of 3: #{index}"
puts ""

# Checking if an element exists in an array
puts "Checking if an element exists in an array:"
puts "Is 3 in the array? #{array_literal.include?(3)}"
puts "Is 10 in the array? #{array_literal.include?(10)}"
puts ""

# Reversing an array
puts "Reversing an array:"
reversed_array = array_literal.reverse
puts reversed_array.inspect
puts ""

# Sorting an array
puts "Sorting an array:"
sorted_array = array_literal.sort
puts sorted_array.inspect
puts ""

# Concatenating arrays
puts "Concatenating arrays:"
new_array = [9, 10]
concatenated_array = array_literal + new_array
puts concatenated_array.inspect
puts ""

# Slicing an array
puts "Slicing an array:"
sliced_array = array_literal[1..3]
puts sliced_array.inspect
puts ""

# Clearing an array
puts "Clearing an array:"
array_literal.clear
puts array_literal.inspect
puts ""
