# Alexander Luna | Assignment 2 | Problem7.rb

# Case 1: Passing immutable object
puts "Case 1: Passing immutable objects"

def update_value(value)
  value = 23
  puts "Inside update_value: #{value}"
end

value = 10
puts "Before calling update_value: #{value}"
update_value(value)
puts "After calling update_value: #{value}"

# Case 2: Passing mutable object
puts "\nCase 2: Passing mutable objects"

def update_array(arr)
  arr << 4
  puts "Inside update_array: #{arr.inspect}"
end

numbers = [1, 2, 3]
puts "Before calling update_array: #{numbers.inspect}"
update_array(numbers)
puts "After calling update_array:  #{numbers.inspect}"

# Case 3: Passing class instances
puts "\nCase 3: Passing class instances"

class Person
  attr_accessor :name, :age
  def initialize(name, age)
    @name = name
    @age = age
  end
end

def update_person(person)
  person.name = "Bob"
  person.age = 30
  puts "Inside update_person: #{person.name} #{person.age}"
end

person = Person.new("Alice", 25)
puts "Before calling update_person: = #{person.name} #{person.age}"
update_person(person)
puts "After calling update_person: #{person.name} #{person.age}"
