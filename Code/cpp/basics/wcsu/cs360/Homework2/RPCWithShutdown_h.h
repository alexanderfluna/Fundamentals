

/* this ALWAYS GENERATED file contains the definitions for the interfaces */


 /* File created by MIDL compiler version 8.01.0628 */
/* at Mon Jan 18 22:14:07 2038
 */
/* Compiler settings for RPCWithShutdown.idl:
    Oicf, W1, Zp8, env=Win32 (32b run), target_arch=X86 8.01.0628 
    protocol : dce , ms_ext, app_config, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
/* @@MIDL_FILE_HEADING(  ) */



/* verify that the <rpcndr.h> version is high enough to compile this file*/
#ifndef __REQUIRED_RPCNDR_H_VERSION__
#define __REQUIRED_RPCNDR_H_VERSION__ 500
#endif

#include "rpc.h"
#include "rpcndr.h"

#ifndef __RPCNDR_H_VERSION__
#error this stub requires an updated version of <rpcndr.h>
#endif /* __RPCNDR_H_VERSION__ */


#ifndef __RPCWithShutdown_h_h__
#define __RPCWithShutdown_h_h__

#if defined(_MSC_VER) && (_MSC_VER >= 1020)
#pragma once
#endif

#ifndef DECLSPEC_XFGVIRT
#if defined(_CONTROL_FLOW_GUARD_XFG)
#define DECLSPEC_XFGVIRT(base, func) __declspec(xfg_virtual(base, func))
#else
#define DECLSPEC_XFGVIRT(base, func)
#endif
#endif

/* Forward Declarations */ 

/* header files for imported files */
#include "oaidl.h"
#include "ocidl.h"

#ifdef __cplusplus
extern "C"{
#endif 


/* interface __MIDL_itf_RPCWithShutdown_0000_0000 */
/* [local] */ 

typedef /* [public][public] */ struct __MIDL___MIDL_itf_RPCWithShutdown_0000_0000_0001
    {
    unsigned long bufferLength;
    /* [size_is][unique] */ byte *buffer;
    } 	BUFFER;



extern RPC_IF_HANDLE __MIDL_itf_RPCWithShutdown_0000_0000_v0_0_c_ifspec;
extern RPC_IF_HANDLE __MIDL_itf_RPCWithShutdown_0000_0000_v0_0_s_ifspec;

#ifndef __ExampleRPC_INTERFACE_DEFINED__
#define __ExampleRPC_INTERFACE_DEFINED__

/* interface ExampleRPC */
/* [implicit_handle][version][uuid] */ 

int ComputeGCD( 
    /* [in] */ int a,
    /* [in] */ int b);

void FactorNumber( 
    /* [out] */ BUFFER *pBuffer,
    int n);

void Shutdown( void);


extern handle_t hRPCWithShutdownBinding;


extern RPC_IF_HANDLE ExampleRPC_v1_0_c_ifspec;
extern RPC_IF_HANDLE ExampleRPC_v1_0_s_ifspec;
#endif /* __ExampleRPC_INTERFACE_DEFINED__ */

/* Additional Prototypes for ALL interfaces */

/* end of Additional Prototypes */

#ifdef __cplusplus
}
#endif

#endif


