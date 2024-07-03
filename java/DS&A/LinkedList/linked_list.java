package java.dataStructures.linkedList;

public class LinkedList {
    private Node head;

    // Node class to represent elements in the linked list
    private static class Node {
        int data;
        Node next;

        Node(int data) {
            this.data = data;
            this.next = null;
        }
    }

    // Method to print the linked list
    public void printList() {
        Node current = head;
        while (current != null) {
            System.out.print(current.data + " ");
            current = current.next;
        }
        System.out.println();
    }

    // Method to insert a new node at the beginning of the linked list
    public void insertAtStart(int data) {
        Node newNode = new Node(data);
        newNode.next = head;
        head = newNode;
    }

    // Method to insert a new node at the end of the linked list
    public void insertAtEnd(int data) {
        Node newNode = new Node(data);
        if (head == null) {
            head = newNode;
            return;
        }

        Node current = head;
        while (current.next != null) {
            current = current.next;
        }
        current.next = newNode;
    }

    public static void main(String[] args) {
        LinkedList myList = new LinkedList();

        myList.insertAtEnd(1);
        myList.insertAtEnd(2);
        myList.insertAtEnd(3);

        System.out.println("Linked List:");
        myList.printList();

        myList.insertAtStart(0);

        System.out.println("Linked List after inserting at the start:");
        myList.printList();
    }
}