# Experiment 1: Passing immutable objects (numbers, booleans, symbols, etc.)
puts "Experiment 1: Passing immutable objects"

def update_value(x)
  x = 42
  puts "Inside update_value: x = #{x}"
end

a = 10
puts "Before calling update_value: a = #{a}"
update_value(a)
puts "After calling update_value: a = #{a}"

# Experiment 2: Passing mutable objects (arrays, hashes, etc.)
puts "\nExperiment 2: Passing mutable objects"

def update_array(arr)
  arr[0] = 99
  puts "Inside update_array: arr = #{arr.inspect}"
end

numbers = [1, 2, 3]
puts "Before calling update_array: numbers = #{numbers.inspect}"
update_array(numbers)
puts "After calling update_array: numbers = #{numbers.inspect}"

# Experiment 3: Passing objects by reference
puts "\nExperiment 3: Passing objects by reference"

class Person
  attr_accessor :name

  def initialize(name)
    @name = name
  end
end

def update_person(person)
  person.name = "Bob"
  puts "Inside update_person: person.name = #{person.name}"
end

person = Person.new("Alice")
puts "Before calling update_person: person.name = #{person.name}"
update_person(person)
puts "After calling update_person: person.name = #{person.name}"
