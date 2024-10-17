// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : ItemInit.cpp
// Description : initialization of processing unit
// ***************************************************************************

// *************************************
//         include files
// *************************************
#pragma once

#include	"StdAfx.h"
#include	<FZ-Include.h>
#include	"ItemDefs.h"
#include <tchar.h>

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
// title         : initialization of procitem
// function name : CLASSNAME(void)
// parameters    : None
// return value  : None
// ***************************************************************************

CLASSNAME::CLASSNAME(void)
{
	this->itemIdent       = _T("InscribedRect");			// procitem identification name
	this->maker           = _T("Yury Puzino");					// procitem creator name
	this->version         = 100;					// version information (*100)
	this->itemKind        = ITEM_IMAGEPROCESS;		// procitem type (=measurement)
	this->setupDataSize   = sizeof(SETUPDATA);		// size of setting data
	this->measureDataSize = sizeof(MEASUREDATA);	// size of measure data
	this->figureDataCount = 0;						// maximum number of figure data
	this->modelDataCount  = 0;						// maximum number of model data
	this->imageDataCount  = 3;						// maximum number of image data
	this->innerUnitCount  = 0;						// maximum number of inner unit
}

CLASSNAME::~CLASSNAME(void)
{
}

ProcItem *CreateProcItem(void)
{
	return(new CLASSNAME());
}

void DeleteProcItem(CLASSNAME *ptrInstance)
{
	delete ptrInstance;
}

