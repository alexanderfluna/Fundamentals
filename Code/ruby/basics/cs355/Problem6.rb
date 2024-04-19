# Experiment 1: Function with no return statement
puts "Experiment 1: Function with no return statement"

def no_return
  x = 42
  y = "Hello"
end

result = no_return
puts "Result: #{result.inspect}"  # Output: Result: nil

# Experiment 2: Function with a single expression
puts "\nExperiment 2: Function with a single expression"

def single_expression
  "Hello, World!"
end

result = single_expression
puts "Result: #{result}"  # Output: Result: Hello, World!

# Experiment 3: Function with multiple expressions
puts "\nExperiment 3: Function with multiple expressions"

def multiple_expressions
  x = 42
  y = "Hello"
  [x, y]
end

result = multiple_expressions
puts "Result: #{result.inspect}"  # Output: Result: [42, "Hello"]
