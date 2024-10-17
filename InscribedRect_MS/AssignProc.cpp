// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : AssignProc.cpp
// Description : Procedure on assingning unit
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
// title         : Procedure on assigning unit in the FLOW and on UI open
// function name : int AssignProc(ptrProcUnit)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::AssignProc(ProcUnit *ptrProcUnit)
{
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();
	if (!ptrMeasureData) {
		return JUDGE_MEMORYERROR;
	}
	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	if (!ptrSetupData) {
		return JUDGE_MEMORYERROR;
	}

	//OveralJudge always 0 on Assignment here.
	//It will be reversed in MeasureProc

	ptrSetupData->overallJudge = 0;

	return(NORMAL);
}

// ***************************************************************************
// title         : Procedure on assigning unit in the FLOW only (Append or Insert)
// function name : int AssignProc2(ptrProcUnit)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************
int CLASSNAME::AssignProc2(ProcUnit* ptrProcUnit) {
	
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();
	if (!ptrMeasureData) {
		return JUDGE_MEMORYERROR;
	}
	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	if (!ptrSetupData) {
		return JUDGE_MEMORYERROR;
	}

	if (ptrSetupData->angle < 0 || ptrSetupData->angle > 90) {
		ptrSetupData->angle = 0;
	}
	

	return(NORMAL);
}

// ***************************************************************************
// title         : Procedure on deleting unit
// function name : int DeleteProc(ptrProcUnit)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::DeleteProc(ProcUnit *ptrProcUnit)
{
	return(NORMAL);
}

// ***************************************************************************
// title         : Processing for unit copy
// function name : int CopyProc(ptrProcUnit, ptrSrcProcUnit)
// parameters    : ProcUnit *ptrProcUnit;		Pointer to processing unit
//				   ProcUnit *ptrSrcProcUnit;	Pointer to source unit
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::CopyProc(ProcUnit *ptrProcUnit, ProcUnit *ptrSrcProcUnit)
{
	return(NORMAL);
}

