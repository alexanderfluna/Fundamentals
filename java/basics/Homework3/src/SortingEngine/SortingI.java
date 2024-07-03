// Alexander Luna | SortingI.java
// Remote interface that allows the client to call the SortingServer using the executeSortingAlgorithm() method.

package SortingEngine;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface SortingI extends Remote{

    // Input: an instance of the SortingAlgorithmI interface
    // Input: an unsorted array of ints
    // Output: the same array after being sorted
    // Called in Client.java by the client stub
    int[] executeSortingAlgorithm(SortingAlgorithmI sortingAlgorithm, int[] arrayToBeSorted) throws RemoteException;
}
