#pragma once

#ifndef __AFXWIN_H__
	#error "include 'stdafx.h' before including this file for PCH"
#endif

#include "resource.h"

class CProcItem_MSApp : public CWinApp
{
public:
	CProcItem_MSApp();

public:
	virtual BOOL InitInstance();

	DECLARE_MESSAGE_MAP()
};

