// Alexander Luna | Client.java
// Obtains an instance of the client stub from the RMI registry.
// Creates two unsorted arrays.
// Prints out their contents.
// Uses the remote interface SortI to have the SortingServer sort the arrays.
// Prints out the contents of the returned sorted arrays.

package SortingEngine;

import java.rmi.NotBoundException;
import java.rmi.RemoteException;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class Client {
    public static void main(String[] args)  {
        try {
            // Get the registry
            Registry rmiRegistry = LocateRegistry.getRegistry("localhost", 1234);
            System.out.println("Got registry");

            // Look up a stub for the remote interface
            SortingI clientStub = (SortingI) rmiRegistry.lookup("SortingServer");
            System.out.println("Got client stub");

            // Create an unsorted array to pass to InsertionSort & print out its contents
            int[] insertionSortArray = {6, 2, 9, 1, 8, 4, 10, 7, 3, 5};
            System.out.println("\nUnsorted insertionSortArray:");
            printArray(insertionSortArray);

            // Use the remote interface to have the sorting server sort the array
            SortingAlgorithmI insertionSort = new InsertionSort();
            insertionSortArray = clientStub.executeSortingAlgorithm(insertionSort, insertionSortArray);

            // Print out the contents of the returned sorted array
            System.out.println("\n\nSorted insertionSortArray:");
            printArray(insertionSortArray);

            // Create an unsorted array to pass to MergeSort & print out its contents
            int[] mergeSortArray = {9, 3, 5, 10, 1, 4, 7, 6, 2, 8};
            System.out.println("\n\nUnsorted mergeSortArray:");
            printArray(mergeSortArray);

            // Use the remote interface to have the sorting server sort the array
            SortingAlgorithmI mergeSort = new MergeSort();
            mergeSortArray = clientStub.executeSortingAlgorithm(mergeSort, mergeSortArray);

            // Print out the contents of the returned sorted array
            System.out.println("\n\nSorted mergeSortArray:");
            printArray(mergeSortArray);

        } catch (RemoteException re) {
            System.out.println("Caught RemoteException: " + re);
        } catch (NotBoundException nbe) {
            System.out.println("Caught NotBoundException: was the server stub not bound?: "
                    + nbe);
        }
    }

    // Input: an array
    // Prints out the array to the terminal
    public static void printArray(int[] array) {
        for (int i : array) {
            System.out.print(i + " ");
        }
    }
}