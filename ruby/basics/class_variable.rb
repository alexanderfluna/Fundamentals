class Counter
  @@count = 0

  def initialize
    @@count += 1
  end

  def self.total_count
    @@count
  end
end

counter1 = Counter.new
counter2 = Counter.new

puts Counter.total_count  # Output: 2
