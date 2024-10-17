// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : Transform.cpp
// Description : Procedure for transformation of coordinates
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
// title         : Transform XY position
// function name : int TransformXY(ptrProcUnit, imageNo, mode, ...)
// parameters    :	ProcUnit *ptrProcUnit;	Pointer to processing unit
//					int      imageNo;		image number
//					int      mode;			Transformation type
//											  0 : After scroll->Before scroll
//											  1 : Before scroll->After scroll
//											  10 : Calibration transformation
//					double   srcX;			original X position
//					double   srcY;			original Y position
//					double   *destX;		converted X position
//					double   *destY;		converted Y position
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::TransformXY(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcX, double srcY, double *destX, double *destY)
{
	//*destX = srcX;
	//*destY = srcY;

	return (NORMAL);
}

// ***************************************************************************
// title         : Transform angle
// function name : int TransformAngle(ptrProcUnit, imageNo, mode, ...)
// parameters    :	ProcUnit *ptrProcUnit;	Pointer to processing unit
//					int      imageNo;		image number
//					int      mode;			Transformation type
//											  0 : After scroll->Before scroll
//											  1 : Before scroll->After scroll
//											  10 : Calibration transformation
//					double   srcAngle;		original Angle
//					double   *destAngle;	converted Angle
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::TransformAngle(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcAngle, double *destAngle)
{
	//*destAngle = srcAngle;

	return (NORMAL);
}

// ***************************************************************************
// title         : Transform area
// function name : int TransformArea(ptrProcUnit, imageNo, mode, ...)
// parameters    :	ProcUnit *ptrProcUnit;	Pointer to processing unit
//					int      imageNo;		image number
//					int      mode;			Transformation type
//											  0 : After scroll->Before scroll
//											  1 : Before scroll->After scroll
//											  10 : Calibration transformation
//					double   srcArea;		original Area
//					double   *destArea;		converted Area
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::TransformArea(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcArea, double *destArea)
{
	//*destArea = srcArea;

	return (NORMAL);
}

// ***************************************************************************
// title         : Transform distance
// function name : int TransformDist(ptrProcUnit, imageNo, mode, ...)
// parameters    :	ProcUnit *ptrProcUnit;	Pointer to processing unit
//					int      imageNo;		image number
//					int      mode;			Transformation type
//											  0 : After scroll->Before scroll
//											  1 : Before scroll->After scroll
//											  10 : Calibration transformation
//					double   srcDist;		original Distance
//					double   *destDist;		converted Distance
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::TransformDist(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcDist, double *destDist)
{
	//*destDist = srcDist;

	return (NORMAL);
}

// ***************************************************************************
// title         : Transform line
// function name : int TransformLine(ptrProcUnit, imageNo, mode, ...)
// parameters    :	ProcUnit *ptrProcUnit;	Pointer to processing unit
//					int      imageNo;		image number
//					int      mode;			Transformation type
//											  0 : After scroll->Before scroll
//											  1 : Before scroll->After scroll
//											  10 : Calibration transformation
//					double   srcA;			original Parameter A
//					double   srcB;			original Parameter B
//					double   srcC;			original Parameter C
//					double   *destA;		Converted Parameter A
//					double   *destB;		Converted Parameter B
//					double   *destC;		Converted Parameter C
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::TransformLine(ProcUnit *ptrProcUnit, int imageNo, int mode, 
				double srcA, double srcB, double srcC, double *destA, double *destB, double *destC)
{
	//*destA = srcA;
	//*destB = srcB;
	//*destC = srcC;

	return (NORMAL);
}
