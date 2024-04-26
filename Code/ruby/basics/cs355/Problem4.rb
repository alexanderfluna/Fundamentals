# Alexander Luna | Assignment 2 | Problem4.rb

# Case 1: Scope
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

# Case 2: Loops

# 2.1 for loop
print "Case 2.1:\t"
for i in 0..3 do
  print i
end

# 2.2: while loop
print "\nCase 2.2:\t"
i = 0
while i < 4 do
  print i
  i += 1
end

# 2.3:

# 2.4:




# Case 3

# Case 4

# Case 5

# Case 6
