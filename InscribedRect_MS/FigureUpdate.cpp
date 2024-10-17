// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : FigureUpdate.cpp
// Description : Procedure when figure data is updated
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
// title         : Procedure when figure data is updated
// function name : int FigureUpdate(ptrProcUnit, figureNo)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   int      figureNo;		figure number
// return value  : Error code
//					  NORMAL(0) : exit normally
//					  else      : error exit
// ***************************************************************************

int CLASSNAME::FigureUpdate(ProcUnit *ptrProcUnit, int figureNo)
{
	return(NORMAL);
}

