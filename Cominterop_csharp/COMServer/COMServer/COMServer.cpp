// COMServer.cpp : Implementation of DLL Exports.


#include "stdafx.h"
#include "resource.h"


// The module attribute causes DllMain, DllRegisterServer and DllUnregisterServer to be automatically implemented for you
[ module(dll, uuid = "{A6A3FBF5-0328-4B6E-87E1-EB605798866B}", 
		 name = "COMServer", 
		 helpstring = "COMServer 1.0 Type Library",
		 resource_name = "IDR_COMSERVER") ]
class CCOMServerModule
{
public:
// Override CAtlDllModuleT members
};
		 
