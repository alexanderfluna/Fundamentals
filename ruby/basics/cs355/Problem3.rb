# Alexander Luna | Assignment 2 | Problem3.rb

def side_effect
  puts "Side effect"
  return true
end

puts "Case 1:"
puts "Short-circuit evaluation:"
result = false && side_effect
puts "Result: #{result}"
puts "\n"

puts "Case 2:"
puts "Non short-circuit evaluation:"
result = true && side_effect
puts "Result: #{result}"
puts "\n"

puts "Case 3:"
puts "Short-circuit evaluation:"
result = true || side_effect
puts "Result: #{result}"
puts "\n"

puts "Case 4:"
puts "Non short-circuit evaluation:"
result = false || side_effect
puts "Result: #{result}"
