// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : SaveLoad.cpp
// Description : Saving and loading setting data
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
// title         : Save data of processing unit
// function name : int SaveProc(ptrProcUnit, ptrSaveInfo)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   SaveInfo *ptrSaveInfo;	Pointer to saving data infomation
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::SaveProc(ProcUnit *ptrProcUnit, SaveInfo *ptrSaveInfo)
{
	int			ret;

	ret = ProcItem::SaveProc(ptrProcUnit, ptrSaveInfo);

	return(ret);
}

// ***************************************************************************
// title         : Load data of processing unit
// function name : int LoadProc(ptrProcUnit, ptrLoadInfo)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   LoadInfo *ptrLoadInfo;	Pointer to loading data infomation
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::LoadProc(ProcUnit *ptrProcUnit, LoadInfo *ptrLoadInfo)
{
	int			ret;

	ret = ProcItem::LoadProc(ptrProcUnit, ptrLoadInfo);

	return(ret);
}

// ***************************************************************************
// title         : Load setting data of processing unit
// function name : int LoadSetupData(ptrProcUnit, loadAddress, loadSize)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//					void    *loadAddress;	Pointer to loaded setting data
//					int     loadSize;		Size of loaded setting data
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::LoadSetupData(ProcUnit *ptrProcUnit, void *loadAddress, int loadSize)
{
	if (loadSize != this->setupDataSize) {
		return(-1);
	}

	memcpy(ptrProcUnit->GetSetupData(), loadAddress, loadSize);

	return(NORMAL);
}

