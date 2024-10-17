// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : ThroughProc.cpp
// Description : Procedure for image input or create for through display
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
// title         : Procedure for image input or create for through display
// function name : int ThroughProc(ptrProcUnit)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::ThroughProc(ProcUnit *ptrProcUnit)
{
	//MeasureProcSub(ptrProcUnit);

	return(NORMAL);
}

