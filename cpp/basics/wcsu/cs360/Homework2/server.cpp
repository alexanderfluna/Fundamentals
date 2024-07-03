// RPCWithShutdownServer.cpp : 

#include <iostream>
#include <vector>
#include "RPCWithShutdown_h.h"

// Server functions.
int ComputeGCD(int a, int b)
{
    std::cout << "Server: Computing the GCD of " << a << " and " << b << std::endl;

    int t;
    while (b != 0)
    {
        t = b;
        b = a % b;
        a = t;
    }

    std::cout << "Server: The GCD is " << a << std::endl;

    return a;
}

void FactorNumber(BUFFER* pBuffer, int n)
{
    std::cout << "Received the number " << n << std::endl;

    /*std::vector<int> factors;

    // Handle the case of 2 separately
    while (n % 2 == 0) {
        factors.push_back(2);
        n /= 2;
    }

    // Start with trial factor 3
    int factor = 3;

    // Check trial factors up to sqrt(n)
    while (factor * factor <= n) {
        if (n % factor == 0) {
            factors.push_back(factor);
            n /= factor;
        }
        else {
            // Skip even trial factors by increasing factor by 2
            factor += 2;
        }
    }

    // If n is not 1, it's a prime factor itself
    if (n != 1) {
        factors.push_back(n);
    }

    // Put bytes into buffer
    for (int i = 0; i < factors.size(); ++i) {
        std::cout << "Element at index " << i << ": " << factors[i] << std::endl;
    }
    */
}

void Shutdown(void)
{
    // Say our farewells
    std::cout << "Received message from the Client. Press any key to shut the server down.\n";
    system("pause");

    RPC_STATUS status;

    status = RpcMgmtStopServerListening(NULL);

    if (status)
    {
        exit(status);
    }

    status = RpcServerUnregisterIf(NULL, NULL, FALSE);

    if (status)
    {
        exit(status);
    }
}

// Naive security callback.
RPC_STATUS CALLBACK SecurityCallback(RPC_IF_HANDLE /*hInterface*/, void* /*pBindingHandle*/)
{
    return RPC_S_OK; // Always allow anyone.
}

int main()
{
    RPC_STATUS status;

    // Uses the protocol combined with the endpoint for receiving
    // remote procedure calls.
    status = RpcServerUseProtseqEpA(
        (RPC_CSTR)("ncacn_ip_tcp"),     // Use TCP/IP protocol.
        RPC_C_PROTSEQ_MAX_REQS_DEFAULT, // Backlog queue length for TCP/IP.
        (RPC_CSTR)("4747"),             // TCP/IP port to use.
        NULL);                          // No security.

    if (status)
        exit(status);

    // Registers the Example1 interface.
    status = RpcServerRegisterIf2(
        ExampleRPC_v1_0_s_ifspec,              // Interface to register.
        NULL,                                // Use the MIDL generated entry-point vector.
        NULL,                                // Use the MIDL generated entry-point vector.
        RPC_IF_ALLOW_CALLBACKS_WITH_NO_AUTH, // Forces use of security callback.
        RPC_C_LISTEN_MAX_CALLS_DEFAULT,      // Use default number of concurrent calls.
        (unsigned)-1,                        // Infinite max size of incoming data blocks.
        SecurityCallback);                   // Naive security callback.

    if (status)
        exit(status);

    // Start to listen for remote procedure
    // calls for all registered interfaces.
    // This call will not return until
    // RpcMgmtStopServerListening is called.
    status = RpcServerListen(
        1,                                   // Recommended minimum number of threads.
        RPC_C_LISTEN_MAX_CALLS_DEFAULT,      // Recommended maximum number of threads.
        FALSE);                              // Start listening now.

    if (status)
        exit(status);
}

// Memory allocation function for RPC.
// The runtime uses these two functions for allocating/deallocating
// enough memory to pass the string to the server.
void* __RPC_USER midl_user_allocate(size_t size)
{
    return malloc(size);
}

// Memory deallocation function for RPC.
void __RPC_USER midl_user_free(void* p)
{
    free(p);
}

