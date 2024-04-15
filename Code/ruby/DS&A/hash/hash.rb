# Creating an associative array
hash = {
  "name" => "John",
  "age" => 30,
  "city" => "New York"
}

# Accessing elements by key
name = hash["name"]
age = hash["age"]
city = hash["city"]

# Iterating through an associative array
hash.each do |key, value|
  puts "#{key.capitalize}: #{value}"
end

# Adding a new key-value pair
hash["gender"] = "Male"

# Modifying a value for an existing key
hash["age"] = 35

# Removing a key-value pair
hash.delete("city")

# Checking if a key exists
has_name = hash.key?("name")
has_city = hash.key?("city")

# Getting all keys or values
all_keys = hash.keys
all_values = hash.values

# Checking if the hash is empty
is_empty = hash.empty?

# Clearing the hash
hash.clear

# Outputting the results
puts "Name: #{name}"
puts "Age: #{age}"
puts "City: #{city}"

puts "New hash after modifications: #{hash.inspect}"

puts "Does the hash have a 'name' key? #{has_name}"
puts "Does the hash have a 'city' key? #{has_city}"

puts "All keys: #{all_keys}"
puts "All values: #{all_values}"

puts "Is the hash empty? #{is_empty}"
