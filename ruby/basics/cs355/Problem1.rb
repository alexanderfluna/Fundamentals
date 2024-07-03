# Alexander Luna | Assignment 2 | Problem1.rb

class Person
  def initialize(name, age)
    @name = name
    @age = age
  end

  def print_name
    puts "#{@name}"
  end

  def print_age
    puts "#{@age}"
  end
end

alexander = Person.new("Alexander", 23)
alexander.print_name
alexander.print_age
