// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : SetupDisp.cpp
// Description : Procedure of display on procitem UI
// ***************************************************************************

// *************************************
//         include files
// *************************************
#pragma once

#include	"StdAfx.h"
#include	<FZ-Include.h>
#include	"ItemDefs.h"

// *************************************
//         macro definition
// *************************************

// *************************************
//         external declaration
// *************************************

// *************************************
//         static variable
// *************************************

// *************************************
//         external variable
// *************************************

// *************************************
//         function reference
// *************************************

// ***************************************************************************
// title         : Display image on procitem UI
// function name : int SetupDisp(ptrProcUnit, subNo, ptrImageWindow)
// parameters    : ProcUnit    *ptrProcUnit;	Pointer to processing unit
//				   int         subNo;			sub number of display
//				   ImageWindow *ptrImageWindow;	pointer to image window
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::SetupDisp(ProcUnit *ptrProcUnit, int subNo, ImageWindow *ptrImageWindow)
{
	SETUPDATA	*ptrSetupData = ptrProcUnit->GetSetupData();
	IMAGE	*image = ptrProcUnit->GetMeasureImage(0);

	ptrProcUnit->SetMeasureProcMask(TRUE);
	//int ret = MeasureProcSub(ptrProcUnit);
	//show even it is 0x0 px size, yes, ffs!
	if (image != nullptr) {
		ptrImageWindow->ImageDisp(image);
	}

	ptrProcUnit->SetMeasureProcMask(FALSE);

	return(NORMAL);
}

