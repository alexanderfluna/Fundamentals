# Alexander Luna | Assignment 2 | Problem8.rb

class Person
  attr_accessor :name, :age

  def initialize(name, age)
    @name = name
    @age = age
  end
end

puts "Case 1:\n"
person1 = Person.new("Alice", 25)
person1.age = "thirty"
puts person1.name
puts person1.age

puts "\nCase 2:\n"
person2 = Person.new(30, "Bob")
person2.name = 40
puts person2.name
puts person2.age
