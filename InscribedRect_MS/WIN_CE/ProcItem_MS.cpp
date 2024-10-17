#include "stdafx.h"
#include "ProcItem_MS.h"

#ifdef _DEBUG
#define new DEBUG_NEW
#endif

BEGIN_MESSAGE_MAP(CProcItem_MSApp, CWinApp)
END_MESSAGE_MAP()

CProcItem_MSApp::CProcItem_MSApp()
{
}

CProcItem_MSApp theApp;

BOOL CProcItem_MSApp::InitInstance()
{
	CWinApp::InitInstance();

	return TRUE;
}

