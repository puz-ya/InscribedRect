// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : RenumProc.cpp
// Description : Procedure of renumbering processing unit
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
// title         : Procedure of renumbering processing unit
// function name : int RenumProc(ptrProcUnit, ptrRenumInfo)
// parameters    : ProcUnit  *ptrProcUnit;	Pointer to processing unit
//				   RenumInfo *ptrRenumInfo;	Pointer to the renumberinig information
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::RenumProc(ProcUnit *ptrProcUnit, RenumInfo *ptrRenumInfo)
{
	//MeasureProcSub(ptrProcUnit);

	return(NORMAL);
}

