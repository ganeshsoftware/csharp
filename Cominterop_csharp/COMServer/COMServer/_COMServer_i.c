

/* this ALWAYS GENERATED file contains the IIDs and CLSIDs */

/* link this file in with the server and any clients */


 /* File created by MIDL compiler version 6.00.0366 */
/* at Sun Nov 13 23:55:08 2005
 */
/* Compiler settings for _COMServer.idl:
    Oicf, W1, Zp8, env=Win32 (32b run)
    protocol : dce , ms_ext, c_ext, robust
    error checks: allocation ref bounds_check enum stub_data 
    VC __declspec() decoration level: 
         __declspec(uuid()), __declspec(selectany), __declspec(novtable)
         DECLSPEC_UUID(), MIDL_INTERFACE()
*/
//@@MIDL_FILE_HEADING(  )

#pragma warning( disable: 4049 )  /* more than 64k source lines */


#ifdef __cplusplus
extern "C"{
#endif 


#include <rpc.h>
#include <rpcndr.h>

#ifdef _MIDL_USE_GUIDDEF_

#ifndef INITGUID
#define INITGUID
#include <guiddef.h>
#undef INITGUID
#else
#include <guiddef.h>
#endif

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        DEFINE_GUID(name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8)

#else // !_MIDL_USE_GUIDDEF_

#ifndef __IID_DEFINED__
#define __IID_DEFINED__

typedef struct _IID
{
    unsigned long x;
    unsigned short s1;
    unsigned short s2;
    unsigned char  c[8];
} IID;

#endif // __IID_DEFINED__

#ifndef CLSID_DEFINED
#define CLSID_DEFINED
typedef IID CLSID;
#endif // CLSID_DEFINED

#define MIDL_DEFINE_GUID(type,name,l,w1,w2,b1,b2,b3,b4,b5,b6,b7,b8) \
        const type name = {l,w1,w2,{b1,b2,b3,b4,b5,b6,b7,b8}}

#endif !_MIDL_USE_GUIDDEF_

MIDL_DEFINE_GUID(IID, IID_IWelcome,0x015ED275,0x3DE6,0x4716,0xA6,0xFA,0x4E,0xBC,0x71,0xE4,0xA8,0xEA);


MIDL_DEFINE_GUID(IID, IID_IMath,0x2158751B,0x896E,0x461d,0x90,0x12,0xEF,0x16,0x80,0xBE,0x06,0x28);


MIDL_DEFINE_GUID(IID, LIBID_COMServer,0xA6A3FBF5,0x0328,0x4B6E,0x87,0xE1,0xEB,0x60,0x57,0x98,0x86,0x6B);


MIDL_DEFINE_GUID(IID, DIID__ICompletedEvents,0xB2CBBCD3,0x2993,0x4148,0x8E,0xF4,0x35,0x6E,0xAC,0xFD,0x83,0x4B);


MIDL_DEFINE_GUID(CLSID, CLSID_CCOMDemo,0x78E88924,0x824D,0x46E3,0x87,0xFD,0x11,0x1A,0xC2,0x7D,0x7B,0x7A);

#undef MIDL_DEFINE_GUID

#ifdef __cplusplus
}
#endif



