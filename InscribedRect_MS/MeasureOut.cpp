// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : MeasureOut.cpp
// Description : Procedure of outputing measurement result
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
// title         : Output measurement result
// function name : int MeasureOut(ptrProcUnit)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::MeasureOut(ProcUnit *ptrProcUnit)
{
	return(NORMAL);
}

