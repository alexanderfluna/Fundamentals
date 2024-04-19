# Alexander Luna | Assignment 2 | Problem10.rb

def tst_name(str)
  case str
  in /\A([A-Z]?[a-z]*), ([A-Z]?[a-z]*) ([A-Z])\z/
    true
  else
    false
  end
end

puts tst_name("John, Doe A")
puts tst_name("john, doe A")
puts tst_name("John, Doe a")
puts tst_name("John Doe A")
puts tst_name("John, DoeA")
puts tst_name("John, Doe AB")
