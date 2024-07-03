# Alexander Luna | Assignment 2 | Problem4.rb

# Case 1: Scoping method
def big
  def sub1
    x = 7
    sub2
  end

  def sub2
    # Uncommenting the line below gives us the error:
    # undefined local variable or method `x' for main:Object (NameError)
    # y = x
  end

  x = 3
  sub1
end
big

# Case 2: Loop bodies
puts "Case 2: Loop bodies"

# 2.1 for loop
puts "\nCase 2.1: for loop"
for a in 0..3 do
  print a
end

# 2.2: while loop
puts "\nCase 2.2: while loop"
b = 0
while b <= 3 do
  print b
  b += 1
end

# 2.3: each loop
puts "\nCase 2.3: each loop"
(0..3).each do |c|
  print c
end

# 2.4: times loop
puts "\nCase 2.4: times loop"
4.times do |d|
  print d
end

# 2.5: until loop
puts "\nCase 2.5: until loop"
e = 0
until e > 3 do
  print e
  e += 1
end

# 2.6: do-while loop
puts "\nCase 2.6: do-while loop"
f = 0
begin
  print f
  f += 1
end while f <= 3

# 2.7: loop
puts "\nCase 2.7: loop"
g = 0
loop do
  print g
  g += 1
  break if g > 3
end

# 2.8: nested loops
puts "\nCase 2.8: nested loop"
2.times do
  4.times do |h|
    print h
  end
end
puts "\n\n============================"

# Case 3: Method bodies
puts "\nCase 3: Method bodies\n\n"

def method1 # can call method1 and method2
  def method2 # can call method1, method2, method3, and method4
    def method3 # can call method1, method2, method3, and method4
      puts "method3"
      #method1
      #method2
      #method3
      #method4
    end
    def method4 # can call method1, method2, method3, and method4
      puts "method4"
      #method1
      #method2
      #method3
      #method4
    end
    puts "method2"
    #method1
    #method2
    #method3
    #method4
  end
  puts "method1"
  #method1
  #method2
  #method3
  #method4
end

# Top level can call any method no matter how nested
method1
method2
method3
method4
puts "\n============================"

# Case 4: Compound statements
puts "\nCase 4: Compound Statements\n"
x = 8

# 4.1: if statement
puts "\nCase 4.1: if statement"
if Integer === x
  puts "x is #{x}"
end

# 4.2: if-else statement
puts "\nCase 4.2: if-else statement"
if Integer === x
  if x % 2 == 0
    puts "x is even"
  else
    puts "x is odd"
  end
else
  puts "x is not an integer"
end

# 4.3: if-elsif-else statement
puts "\nCase 4.3: if-elsif-else statement"
if Integer === x
  if x >= 10
    puts "x has more than one digit"
  elsif x >= 0 and x < 10
  puts "x is one digit"
  else
    puts "x is negative"
  end
end
puts "\n============================"

# Case 5: Case statement
puts "\nCase 5: Case statement\n\n"
animal = "dog"

case animal
when "dog"
  puts "It's a dog"
when "cat"
  puts "It's a cat"
when "bird"
  puts "It's a bird"
else
  puts "It's something else"
end
puts "\n============================"

# Case 6: Nesting
puts "\nCase 6: Nesting\n"

# 6.1: If statement nested inside loop nested inside method
puts "\nCase 6.1: If statement nested inside loop nested inside method"
def nesting_method
  (0..10).each do |i|
    if i % 2 == 1
      puts "#{i} is negative"
    end
  end
end
nesting_method

# 6.2: Method nested inside loop
puts "\nCase 6.2: Method nested inside loop\n"
3.times do
  def new_method
    puts "new_method"
  end
  new_method
end

# 6.3 Method nested inside compound statement
puts "\nCase 6.3 Method nested inside compound statement\n"
if true
  def new_method
    puts "new_method"
  end
  new_method
end

# 6.4 Method nested inside case statement
puts "\nCase 6.4 Method nested inside case statement\n"
case animal
when "dog"
  def new_method
    puts "new_method"
  end
  new_method
when "cat"
  puts "It's a cat"
when "bird"
  puts "It's a bird"
else
  puts "It's something else"
end

# 6.5 Case statement nested inside method
puts "\nCase 6.5 Case statement nested inside method\n"
def case_statement(animal)
  case animal
  when "dog"
    def new_method
      puts "new_method"
    end
    new_method
  when "cat"
    puts "It's a cat"
  when "bird"
    puts "It's a bird"
  else
    puts "It's something else"
  end
end
case_statement(animal)
