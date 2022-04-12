// COMClient.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include <iostream>
#import "../DotNetComponent/bin/debug/DotnetComponent.tlb"

using namespace std;
using namespace DotnetComponent;


int _tmain(int argc, _TCHAR* argv[])
{
	HRESULT hr;
	hr = CoInitialize(NULL);

	try
	{
		IWelcomePtr spWelcome;
		hr = spWelcome.CreateInstance("Wrox.DotnetComponent");   // CoCreateInstance()

		cout << spWelcome->Greeting("Bill") << endl;

		IMathPtr spMath;
		spMath = spWelcome;	// QueryInterface()

		long result = spMath->Add(4, 5);
		cout << "result:" << result << endl; 
	}

	catch (_com_error& e)
	{
		cout << e.ErrorMessage() << endl;
	}

	CoUninitialize();
	return 0;
}


