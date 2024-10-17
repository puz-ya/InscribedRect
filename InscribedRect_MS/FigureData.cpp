// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : FigureData.cpp
// Description : Procedure to operate figure data of processing unit
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
// title         : Procedure to set the format of figure data
// function name : int SetFigureType(ptrProcUnit, figureNo, type)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   int      figureNo;		Figure number
//				   int      type;			Figure type
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::SetFigureType(ProcUnit *ptrProcUnit, int figureNo, int type)
{
	return(ProcItem::SetFigureType(ptrProcUnit, figureNo, type));
}

// ***************************************************************************
// title         : Procedure to get the format of figure data
// function name : int GetFigureType(ptrProcUnit, figureNo)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   int      figureNo;		Figure number
// return value  : Returns the figure data type of the specified figure number.
//				   If failed to get, returns NULL.
// ***************************************************************************

int CLASSNAME::GetFigureType(ProcUnit *ptrProcUnit, int figureNo)
{
	return(ProcItem::GetFigureType(ptrProcUnit, figureNo));
}

// ***************************************************************************
// title         : Procedure to set the figure data
// function name : int SetFigureData(ptrProcUnit, figureNo, ptrFigure)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   int      figureNo;		Figure number
//				   FIG_HEADER *ptrFigure;	Pointer to setting figure data
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::SetFigureData(ProcUnit *ptrProcUnit, int figureNo, FIG_HEADER *ptrFigure)
{
	return(ProcItem::SetFigureData(ptrProcUnit, figureNo, ptrFigure));
}

// ***************************************************************************
// title         : Procedure to add a figure 
// function name : int AddFigureData(ptrProcUnit, figureNo, type, data)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   int      figureNo;		Figure number
//				   FIG_TYPE *type;			Pointer to the figure data to be added
//				   void     *data;			Pointer to the figure information to be added
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::AddFigureData(ProcUnit *ptrProcUnit, int figureNo, FIG_TYPE *type, void *data)
{
	return(ProcItem::AddFigureData(ptrProcUnit, figureNo, type, data));
}


// ***************************************************************************
// title         : Procedure to get the figure data 
// function name : int GetFigureData(ProcUnit *ptrProcUnit, int figureNo)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   int      figureNo;		Figure number
// return value  : Returns the pointer to the figure data of the specified figure number.
//				   If failed to get, returns NULL.
// ***************************************************************************

FIG_HEADER *CLASSNAME::GetFigureData(ProcUnit *ptrProcUnit, int figureNo)
{
	return(ProcItem::GetFigureData(ptrProcUnit, figureNo));
}

