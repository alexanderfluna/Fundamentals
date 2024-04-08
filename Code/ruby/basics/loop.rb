# Program with three different loops in Ruby

# 1. For Loop
puts "For Loop:"
for i in 1..5 do
  puts i
end

# 2. While Loop
puts "\nWhile Loop:"
i = 1
while i <= 5 do
  puts i
  i += 1
end

# 3. Times Loop
puts "\nTimes Loop:"
5.times do |i|
  puts i + 1
end

1.upto(5) {|x| print x, " "}
