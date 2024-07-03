class Node:

    def __init__(self, data):
        self.data = data
        self.next = None

class LinkedList:

    def __init__(self):
        self.head = None

    def printList(self):
        temp = self.head
        while (temp):
            print(temp.data)
            temp = temp.next

    def insertAtStart(self, data):
        new_node = Node(data)

        if self.head is None:
            self.head = new_node
            return
    
        new_node.next = self.head
        self.head = new_node

    def insertAtEnd(self, data):
        new_node = Node(data)

        if self.head is None:
            self.head = new_node
            return

        last = self.head
        while(last.next):
            last = last.next

        last.next = new_node


if __name__ == "__main__":
    
    list = LinkedList()

    list.insertAtEnd(4)

    list.insertAtStart(3)

    list.insertAtEnd(5)

    list.insertAtStart(2)

    list.insertAtEnd(6)

    list.insertAtStart(1)

    list.printList()