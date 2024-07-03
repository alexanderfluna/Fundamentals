class Person
  def initialize(name)
    @name = name
  end

  def greet
    "Hello, #{@name}!"
  end
end

person1 = Person.new("Alice")
person2 = Person.new("Bob")

puts person1.greet  # Output: Hello, Alice!
puts person2.greet  # Output: Hello, Bob!
