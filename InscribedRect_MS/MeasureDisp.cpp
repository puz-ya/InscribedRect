// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : MeasureDisp.cpp
// Description : Procedure of displaying measurement result
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
// title         : Display result (Image)
// function name : int MeasureDispI(ptrProcUnit, subNo, ptrImageWindow)
// parameters    : ProcUnit    *ptrProcUnit;	Pointer to processing unit
//				   int         subNo;			Sub number of display
//				   ImageWindow *ptrImageWindow;	Pointer to image window
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::MeasureDispI(ProcUnit *ptrProcUnit, int subNo, ImageWindow *ptrImageWindow)
{
	ptrProcUnit->SetMeasureProcMask(TRUE);
	
	//IMAGE *ptrImage = ptrProcUnit->GetImageData(0);
	IMAGE* ptrImage = ptrProcUnit->GetMeasureImage(0);
	ptrImageWindow->ImageDisp(ptrImage);

	ptrProcUnit->SetMeasureProcMask(FALSE);

    return(NORMAL);
}

// ***************************************************************************
// title         : Display result (Graphic)
// function name : int MeasureDispG(ptrProcUnit, subNo, ptrImageWindow)
// parameters    : ProcUnit    *ptrProcUnit;	Pointer to processing unit
//				   int         subNo;			Sub number of display
//				   ImageWindow *ptrImageWindow;	Pointer to image window
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::MeasureDispG(ProcUnit *ptrProcUnit, int subNo, ImageWindow *ptrImageWindow)
{
	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

	const int MAX_RECT_VERT = 4;
	int x[MAX_RECT_VERT];
	int y[MAX_RECT_VERT];

	for (int i = 0; i < MAX_RECT_VERT; i++) {
		x[i] = ptrMeasureData->vert[i].x;
		y[i] = ptrMeasureData->vert[i].y;
	}

	//200, 100, 0 - orange/brown
	ptrImageWindow->SetDrawStyle(PS_SOLID, 3, RGB(200, 100, 0));
	ptrImageWindow->DrawPolygon(4, x, y);

	if (ptrSetupData->sliceEnabled == 1) {

		//The order of points is bottomLeft, topLeft, topRight, bottomRight.
		
		int r = 5;	//radius of circles

		//Left + Right sides of main rectangle
		int sizeLeftRight = ptrMeasureData->pointsOfSliceLeft.size();
		for (int i = 1; i < sizeLeftRight - 1; i++) {
			//200, 100, 0 - orange/brown
			ptrImageWindow->SetDrawStyle(PS_SOLID, 3, RGB(200, 100, 0));

			ptrImageWindow->DrawCircle(
				ptrMeasureData->pointsOfSliceLeft[i].x,
				ptrMeasureData->pointsOfSliceLeft[i].y,
				r);

			ptrImageWindow->DrawCircle(
				ptrMeasureData->pointsOfSliceRight[i].x,
				ptrMeasureData->pointsOfSliceRight[i].y,
				r);

			//180, 150, 0 - golden
			ptrImageWindow->SetDrawStyle(PS_DASH, 1, RGB(180, 150, 0));

			ptrImageWindow->DrawLine(ptrMeasureData->pointsOfSliceLeft[i].x, ptrMeasureData->pointsOfSliceLeft[i].y,
				ptrMeasureData->pointsOfSliceRight[i].x, ptrMeasureData->pointsOfSliceRight[i].y);
		}

		//Top + Bottom sides of main rectangle
		int sizeTopBottom = ptrMeasureData->pointsOfSliceTop.size();
		for (int i = 1; i < sizeTopBottom - 1; i++) {

			//200, 100, 0 - orange/brown
			ptrImageWindow->SetDrawStyle(PS_SOLID, 3, RGB(200, 100, 0));

			ptrImageWindow->DrawCircle(
				ptrMeasureData->pointsOfSliceTop[i].x,
				ptrMeasureData->pointsOfSliceTop[i].y,
				r);

			ptrImageWindow->DrawCircle(
				ptrMeasureData->pointsOfSliceBottom[i].x,
				ptrMeasureData->pointsOfSliceBottom[i].y,
				r);

			//180, 150, 0 - golden
			ptrImageWindow->SetDrawStyle(PS_DASH, 1, RGB(180, 150, 0));

			ptrImageWindow->DrawLine(ptrMeasureData->pointsOfSliceTop[i].x, ptrMeasureData->pointsOfSliceTop[i].y,
				ptrMeasureData->pointsOfSliceBottom[i].x, ptrMeasureData->pointsOfSliceBottom[i].y);
		}

	}

	return(NORMAL);
}

// ***************************************************************************
// title         : Display result (Text)
// function name : int MeasureDispT(ptrProcUnit, subNo, ptrTextWindow)
// parameters    : ProcUnit     *ptrProcUnit;	Pointer to processing unit
//					int         subNo;			Sub number of display
//					TextWindow  *ptrTextWindow;	Pointer to text window
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::MeasureDispT(ProcUnit *ptrProcUnit, int subNo, TextWindow *ptrTextWindow)
{
	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

	//display measurement result
	int judge = ptrProcUnit->GetUnitJudge();
	ptrTextWindow->DrawJudgeText(judge);

	//Formats to output (same as sprintf)
	//%d - integer
	//%.2f - float
	//%s - string

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Mode: %d"), ptrSetupData->mode + 1);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Max angle: %d"), ptrSetupData->max_angle);
	
	if (ptrSetupData->mode == 0) {
		ptrTextWindow->DrawTextW(judge, TRUE, _T("Angle skip: %d"), ptrSetupData->mode01_skip_angle);
	}
	if (ptrSetupData->mode == 1) {
		ptrTextWindow->DrawTextW(judge, TRUE, _T("Angle skip: %d"), ptrSetupData->mode02_skip_angle);
	}

	ptrTextWindow->DrawTextW(judge, TRUE, _T("--- --- --- --- ---"));

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Point 1: (%.0f ; %.0f)"), ptrMeasureData->vert[0].x, ptrMeasureData->vert[0].y);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Point 2: (%.0f ; %.0f)"), ptrMeasureData->vert[1].x, ptrMeasureData->vert[1].y);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Point 3: (%.0f ; %.0f)"), ptrMeasureData->vert[2].x, ptrMeasureData->vert[2].y);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Point 4: (%.0f ; %.0f)"), ptrMeasureData->vert[3].x, ptrMeasureData->vert[3].y);

	//ptrTextWindow->DrawTextW(judge, TRUE, _T("X2: %.2f"), ptrMeasureData->vert[1].x);
	//ptrTextWindow->DrawTextW(judge, TRUE, _T("Y2: %.2f"), ptrMeasureData->vert[1].y);

	//ptrTextWindow->DrawTextW(judge, TRUE, _T("X3: %.2f"), ptrMeasureData->vert[2].x);
	//ptrTextWindow->DrawTextW(judge, TRUE, _T("Y3: %.2f"), ptrMeasureData->vert[2].y);

	//ptrTextWindow->DrawTextW(judge, TRUE, _T("X4: %.2f"), ptrMeasureData->vert[3].x);
	//ptrTextWindow->DrawTextW(judge, TRUE, _T("Y4: %.2f"), ptrMeasureData->vert[3].y);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("--- --- --- --- ---"));

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Area: %d"), ptrMeasureData->area);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Width: %d"), ptrMeasureData->width);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Height: %d"), ptrMeasureData->height);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Center X: %d"), ptrMeasureData->center_x);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Center Y: %d"), ptrMeasureData->center_y);

	ptrTextWindow->DrawTextW(judge, TRUE, _T("--- --- --- --- ---"));

	ptrTextWindow->DrawTextW(judge, TRUE, _T("Slice enabled: %d"), ptrSetupData->sliceEnabled);
	
	if (ptrSetupData->sliceEnabled == 1) {

		if (ptrSetupData->sliceType == SLICE_ROWS_COLS) {
			ptrTextWindow->DrawTextW(judge, TRUE, _T("Slice type: Rows & Cols"));
		}
		else {
			ptrTextWindow->DrawTextW(judge, TRUE, _T("Slice type: Height & Width"));
		}

		ptrTextWindow->DrawTextW(judge, TRUE, _T("Slice rows: %d"), ptrSetupData->sliceRows);

		ptrTextWindow->DrawTextW(judge, TRUE, _T("Slice cols: %d"), ptrSetupData->sliceCols);

		ptrTextWindow->DrawTextW(judge, TRUE, _T("Slice height: %d"), ptrSetupData->sliceHeight);

		ptrTextWindow->DrawTextW(judge, TRUE, _T("Slice width: %d"), ptrSetupData->sliceWidth);

	}

	ptrTextWindow->DrawTextW(judge, TRUE, _T("--- --- --- --- ---"));
	return(NORMAL);
}

