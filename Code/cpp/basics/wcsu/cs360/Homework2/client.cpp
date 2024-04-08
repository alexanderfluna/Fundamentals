// RPCWithShutdownClient.cpp 

#include <iostream>
#include "RPCWithShutdown_h.h"

int main()
{
    RPC_STATUS status;
    RPC_CSTR szStringBinding = NULL;

    // Creates a string binding handle.
    // This function is nothing more than a printf.
    // Connection is not done here.
    status = RpcStringBindingComposeA(
        NULL,                       // UUID to bind to.
        (RPC_CSTR)("ncacn_ip_tcp"), // Use TCP/IP protocol.
        (RPC_CSTR)("localhost"),    // TCP/IP network address to use.
        (RPC_CSTR)("4747"),         // TCP/IP port to use.
        NULL,                       // Protocol dependent network options to use.
        &szStringBinding);          // String binding output.

    if (status)
    {
        exit(status);
    }

    // Validates the format of the string binding handle and converts
    // it to a binding handle.
    // Connection is not done here either.
    status = RpcBindingFromStringBindingA(
        szStringBinding,               // The string binding to validate.
        &hRPCWithShutdownBinding);     // Put the result in the implicit binding
                                       // handle defined in the IDL file.

    if (status)
    {
        exit(status);
    }

    RpcTryExcept
    {
        // Calls the RPC function. The hExample1Binding binding handle
        // is used implicitly.
        // Connection is done here.
       
        // GCD
        int a = 24;
        int b = 128;
        int GCD = ComputeGCD(a, b);
        std::cout << "Client: Sending " << a << " and " << b << " to the Server." << "\n";
        std::cout << "Client: The GCD of " << a << " and " << b << " is " << GCD << "\n";

        BUFFER buffer;
        buffer.bufferLength = 0;
        buffer.buffer = 0;
        int number = 64;
        FactorNumber(&buffer, number);
        //std::cout << "Sent the number " << number << std::endl;
        midl_user_free(buffer.buffer);

        // Shutdown
        std::cout << "Sending message to the Server to shut down." << "\n";
        system("pause");
        Shutdown();
    }
        RpcExcept(1)
    {
        std::cerr << "Runtime reported exception " << RpcExceptionCode()
            << std::endl;
    }
    RpcEndExcept

        // Free the memory allocated by a string.
        status = RpcStringFreeA(
            &szStringBinding); // String to be freed.

    if (status)
        exit(status);

    // Releases binding handle resources and disconnects from the server.
    status = RpcBindingFree(
        &hRPCWithShutdownBinding); // Frees the implicit binding handle defined in the IDL file.

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

