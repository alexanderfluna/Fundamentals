class Node
  attr_accessor :data, :next_node

  def initialize(data)
    @data = data
    @next_node = nil
  end
end

class LinkedList
  attr_accessor :head

  def initialize
    @head = nil
  end

  # Method to insert a new node at the beginning of the linked list
  def insert(data)
    new_node = Node.new(data)
    if @head.nil?
      @head = new_node
    else
      new_node.next_node = @head
      @head = new_node
    end
  end

  # Method to display the linked list
  def display
    current = @head
    while current != nil
      print "#{current.data} -> "
      current = current.next_node
    end
    puts "nil"
  end
end

# Example usage:
list = LinkedList.new
list.insert(10)
list.insert(20)
list.insert(30)

puts "Linked List:"
list.display
