// Alexander Luna | SortingServer.java
// Registers the SortingServer with the RMI registry

package SortingEngine;

import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;
import java.rmi.registry.LocateRegistry;
import java.rmi.registry.Registry;

public class SortingServer implements SortingI {

    // Empty constructor
    public SortingServer() {}

    // Input: an instance of the SortingAlgorithmI interface
    // Input: an unsorted array of ints
    // Output: the same array after being sorted
    @Override
    public int[] executeSortingAlgorithm(SortingAlgorithmI sortingAlgorithm, int[] arrayToBeSorted) {
        return sortingAlgorithm.sort(arrayToBeSorted);
    }

    // Main method
    public static void main(String[] args) {
        try {
            // Create our Sorting Server
            SortingServer server = new SortingServer();

            // Create the server stub
            SortingI serverStub = (SortingI)
            UnicastRemoteObject.exportObject(server, 1234);

            // Create RMI registry
            Registry rmiRegistry = LocateRegistry.createRegistry(1234);

            // Bind the stub in the registry
            rmiRegistry.rebind("SortingServer", serverStub);

            // The server has started
            System.out.println("SortingServer started");
        }
        catch(RemoteException  re )
        {
            System.out.println("Caught Remote Exception creating server artifacts: " + re);
            re.printStackTrace();
        }
    }
}
