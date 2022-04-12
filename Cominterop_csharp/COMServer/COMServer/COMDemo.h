// COMDemo.h : Declaration of the CCOMDemo

#pragma once
#include "resource.h"       // main symbols




#if defined(_WIN32_WCE) && !defined(_CE_DCOM) && !defined(_CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA)
#error Single-threaded COM objects are not properly supported on Windows CE platforms that do not include full DCOM support.  Define _CE_ALLOW_SINGLE_THREADED_OBJECTS_IN_MTA to force ATL to support them anyway. You must also change the threading model in your rgs file from 'Apartment'/'Single' to 'Free'.
#endif


// IWelcome
[
	object,
	uuid("015ED275-3DE6-4716-A6FA-4EBC71E4A8EA"),
	dual,	helpstring("IWelcome Interface"),
	pointer_default(unique),
	custom(0F21F359-AB84-41e8-9A78-36D110E6D2F9, 
	"Wrox.ProCSharp.COMInterop.Server.IWelcome")

]
__interface IWelcome : IDispatch
{
	[id(1), helpstring("method Greeting")] HRESULT Greeting([in] BSTR name, [out,retval] BSTR* message);
};

// IMath
[
	object,
	uuid("2158751B-896E-461d-9012-EF1680BE0628"),
	dual,	
	helpstring("IMath Interface"),
	pointer_default(unique),
	custom(0F21F359-AB84-41e8-9A78-36D110E6D2F9, 
	"Wrox.ProCSharp.COMInterop.Server.IMath")
]
__interface IMath : IDispatch
{
	[id(1)] HRESULT Add([in] LONG val1, [in] LONG val2, [out, retval] LONG* result);
	[id(2)] HRESULT Sub([in] LONG val1, [in] LONG val2, [out, retval] LONG* result);
};


// _ICompletedEvents
[
	dispinterface,
	uuid("B2CBBCD3-2993-4148-8EF4-356EACFD834B"),
	custom(0F21F359-AB84-41e8-9A78-36D110E6D2F9, 
	"Wrox.ProCSharp.COMInterop.Server.ICompletedEvents"),
	helpstring("_ICompletedEvents Interface")
]
__interface _ICompletedEvents
{
	[id(1)] void Completed(void);
};



// CCOMDemo

[
	coclass,
	threading(apartment),
	vi_progid("COMServer.COMDemo"),
	progid("COMServer.COMDemo.1"),
	version(1.0),
	custom(0F21F359-AB84-41e8-9A78-36D110E6D2F9, 
	"Wrox.ProCSharp.COMInterop.Server.COMDemo"),
	uuid("78E88924-824D-46E3-87FD-111AC27D7B7A"),
	event_source(com),
	helpstring("COMDemo Class")
]
class ATL_NO_VTABLE CCOMDemo : 
	public IWelcome, public IMath
{
public:
	CCOMDemo()
	{
	}

	__event __interface _ICompletedEvents;
	void FireCompleted()
	{
		__raise Completed();
	}   



	DECLARE_PROTECT_FINAL_CONSTRUCT()

	HRESULT FinalConstruct()
	{
		return S_OK;
	}

	void FinalRelease() 
	{
	}

public:

	STDMETHOD(Greeting)(BSTR name, BSTR* message);
	STDMETHOD(Add)(LONG val1, LONG val2, LONG* result);
	STDMETHOD(Sub)(LONG val1, LONG val2, LONG* result);
};

