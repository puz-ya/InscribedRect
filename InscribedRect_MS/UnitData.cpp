// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : UnitData.cpp
// Description : Procesure to set / get processing unit data
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

typedef struct {
	int no;
	TCHAR* name;
} UDATA;

static const UDATA unitParam[] = {
	{0, _T("Judge")},
	{0, _T("JG")},

	{20, _T("unit1")},	//1st scan edge position
	{21, _T("unit2")},	//2nd scan edge position
	{22, _T("unit3")},	//3rd scan edge position
	{23, _T("unit4")},	//4th scan edge position
	
	//Output tab has DEFAULT idents [101-103] for all FH / FHV units
	{101, _T("outputCoordinate")},	//0: after scroll, 1: before scroll
	{102, _T("calibration")},		//0: OFF, 1: ON
	{103, _T("overallJudge")},		//0: ON, 1: OFF (inveterted in MeasureProc)
	{103, _T("OJ")},



	{200, _T("mode")},	//number of algo we're using
	{200, _T("MD")},	//number of algo we're using
	{201, _T("max_angle")},	//max rotation angle to check all rect (0 to angle)
	{201, _T("MAXANG")},	//max rotation angle to check all rect (0 to angle)

	{210, _T("sliceEnabled")},	//flag for slicing, special points on the edges
	{211, _T("sliceType")},		//flag what comes first: 1 [rows & cols] or 2 [height & width]
	{212, _T("sliceRows")},		//number of desired rows
	{213, _T("sliceCols")},		//number of desired cols
	{214, _T("sliceHeight")},	//number of desired height
	{215, _T("sliceWidth")},	//number of desired width



	{300, _T("m01angleSkip")},	//number angles to skip while rotating in Mode01

	{400, _T("m02angleSkip")},	//number angles to skip while rotating in Mode02
	{401, _T("m02scaleStep")},	//number angles to skip while rotating in Mode02

	{999, _T("remeasure")},

	//Output values
	{1000, _T("x1")},
	{1001, _T("y1")},
	{1002, _T("x2")},
	{1003, _T("y2")},
	{1004, _T("x3")},
	{1005, _T("y3")},
	{1006, _T("x4")},
	{1007, _T("y4")},
	
	{1010, _T("area")},		//area
	{1010, _T("AR")},		//area

	{1011, _T("width")},	//width
	{1011, _T("WT")},	//width
	{1012, _T("height")},	//height
	{1012, _T("HT")},	//height

	{1013, _T("center_x")},	//center_x
	{1013, _T("CX")},	//center_x
	{1014, _T("center_y")},	//center_y
	{1014, _T("CY")},	//center_y

	{-1, NULL}
};

// *************************************
//         external variable
// *************************************

// *************************************
//         function reference
// *************************************

// ***************************************************************************
// title         : set processing unit data by number
// function name : int SetUnitData(ptrProcUnit, dataNo, data)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   int      dataNo;			Data number.
//				   ANYTYPE  *data;			Setting data
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::SetUnitData(ProcUnit *ptrProcUnit, int dataNo, ANYTYPE *data)
{
	int ret = NORMAL;
	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

	if (ptrSetupData == nullptr || ptrMeasureData == nullptr) {
		return -1;
	}

	switch (dataNo) {
	case 20:
		ptrSetupData->unitPos1 = data->GetIVal();
		break;

	case 21:
		ptrSetupData->unitPos2 = data->GetIVal();
		break;
	
	case 22:
		ptrSetupData->unitPos3 = data->GetIVal();
		break;

	case 23:
		ptrSetupData->unitPos4 = data->GetIVal();
		break;
	
		//Output tab, overall judgement switch
		//{103, _T("overallJudge")},
	case 103:
		if (data->GetIVal() < 0 || data->GetIVal() > 1) {
			ret = -1;
		}
		else {
			ptrSetupData->overallJudge = data->GetIVal();
		}
		break;

		//{ 200, _T("mode") },	//number of algo we're using
	case 200:
		ptrSetupData->mode = data->GetIVal();
		break;

		//{ 201, _T("angle") },	//max rotation angle to check all rect (0 to angle)
	case 201:
		ptrSetupData->max_angle = data->GetIVal();
		break;

		//{ 210, _T("sliceEnabled") },	//flag for slicing, special points on the edges
	case 210:
		ptrSetupData->sliceEnabled = data->GetIVal();
		break;

		//{ 211, _T("sliceType") },		//flag what comes first: [rows & cols] or [height & width]
	case 211:
		ptrSetupData->sliceType = data->GetIVal();
		break;

		//{ 212, _T("sliceRows") },		//number of desired rows
	case 212:
		ptrSetupData->sliceRows = data->GetIVal();
		break;

		//{ 213, _T("sliceCols") },		//number of desired cols
	case 213:
		ptrSetupData->sliceCols = data->GetIVal();
		break;

		//{ 214, _T("sliceHeight") },	//number of desired height
	case 214:
		ptrSetupData->sliceHeight = data->GetIVal();
		break;

		//{ 215, _T("sliceWidth") },	//number of desired width
	case 215:
		ptrSetupData->sliceWidth = data->GetIVal();
		break;


		//{ 300, _T("m01angleSkip") },	//number angles to skip while rotating in Mode01
	case 300:
		ptrSetupData->mode01_skip_angle = data->GetIVal();
		break;

		//{ 400, _T("m02angleSkip") },	//number angles to skip while rotating in Mode02
	case 400:
		ptrSetupData->mode02_skip_angle = data->GetIVal();
		break;

		//{ 401, _T("m02scaleStep") },	//number angles to skip while rotating in Mode02
	case 401:
		ptrSetupData->mode02_step_scale = data->GetDoubleValue();
		break;

		//{ 999, _T("remeasure")},
	case 999:
		if (data->GetIntValue() == 7) {
		
			MeasureProcSub(ptrProcUnit);

		};
		break;

	default:
		ret = -1;
	}

	return(ret);
}

// ***************************************************************************
// title         : set processing unit data by number
// function name : int SetUnitData(ptrProcUnit, dataIdent, data)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   TCHAR    *dataIdent;		Data identification name
//				   ANYTYPE  *data;			Setting data
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::SetUnitData(ProcUnit *ptrProcUnit, TCHAR *dataIdent, ANYTYPE *data)
{
	int ret = -1;

	////some internal FH-AP system param slowing us down on SetupWindow open ffs
	//if (_tcsicmp(dataIdent, _T("uiIdent")) == 0) {
	//	return ret;
	//}

	for (int i = 0; unitParam[i].no != -1; ++i) {
		if (_tcsicmp(dataIdent, unitParam[i].name) == 0) {
			ret = this->SetUnitData(ptrProcUnit, unitParam[i].no, data);
			break;
		}
	}
	return(ret);
}

// ***************************************************************************
// title         : get processing unit data by number
// function name : int GetUnitData(ptrProcUnit, dataNo, data)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   int      dataNo;			Data number.
//				   ANYTYPE  *data;			Getting data
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::GetUnitData(ProcUnit *ptrProcUnit, int dataNo, ANYTYPE *data)
{
	int ret = NORMAL;
	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

	if (ptrSetupData == nullptr || ptrMeasureData == nullptr) {
		return -1;
	}

	switch (dataNo) {
		//0 == JG
	case 0:
		data->SetData(ptrProcUnit->GetUnitJudge());
		break;

		// {103, _T("overallJudge")},
	case 103:
		data->SetData(ptrSetupData->overallJudge);
		break;
	
		//{ 200, _T("mode") },	//number of algo we're using
	case 200:
		data->SetData(ptrSetupData->mode);
		break;

		//{ 201, _T("angle") },	//max rotation angle to check all rect (0 to angle)
	case 201:
		data->SetData(ptrSetupData->max_angle);
		break;



		//{ 210, _T("sliceEnabled") },	//flag for slicing, special points on the edges
	case 210:
		data->SetData(ptrSetupData->sliceEnabled);
		break;

		//{ 211, _T("sliceType") },		//flag what comes first: [rows & cols] or [height & width]
	case 211:
		data->SetData(ptrSetupData->sliceType);
		break;

		//{ 212, _T("sliceRows") },		//number of desired rows
	case 212:
		data->SetData(ptrSetupData->sliceRows);
		break;

		//{ 213, _T("sliceCols") },		//number of desired cols
	case 213:
		data->SetData(ptrSetupData->sliceCols);
		break;

		//{ 214, _T("sliceHeight") },	//number of desired height
	case 214:
		data->SetData(ptrSetupData->sliceHeight);
		break;

		//{ 215, _T("sliceWidth") },	//number of desired width
	case 215:
		data->SetData(ptrSetupData->sliceWidth);
		break;



		//{ 300, _T("m01angleSkip") },	//number angles to skip while rotating in Mode01
	case 300:
		data->SetData(ptrSetupData->mode01_skip_angle);
		break;

		//{ 400, _T("m02angleSkip") },	//number angles to skip while rotating in Mode02
	case 400:
		data->SetData(ptrSetupData->mode02_skip_angle);
		break;

		//{ 401, _T("m02scaleStep") },	//number angles to skip while rotating in Mode02
	case 401:
		data->SetData(ptrSetupData->mode02_step_scale);
		break;

		//--- --- --- Output measurement values

	//{ 1000, _T("x1") },
	case 1000:
		data->SetData(ptrMeasureData->vert[0].x);
		break;

	//{ 1001, _T("y1") },
	case 1001:
		data->SetData(ptrMeasureData->vert[0].y);
		break;

	//{ 1002, _T("x2") },
	case 1002:
		data->SetData(ptrMeasureData->vert[1].x);
		break;

	//{ 1003, _T("y2") },
	case 1003:
		data->SetData(ptrMeasureData->vert[1].y);
		break;

	//{ 1004, _T("x3") },
	case 1004:
		data->SetData(ptrMeasureData->vert[2].x);
		break;
	//{ 1005, _T("y3") },
	case 1005:
		data->SetData(ptrMeasureData->vert[2].y);
		break;

	//{ 1006, _T("x4") },
	case 1006:
		data->SetData(ptrMeasureData->vert[3].x);
		break;
	//{ 1007, _T("y4") },
	case 1007:
		data->SetData(ptrMeasureData->vert[3].y);
		break;

	//{ 1010, _T("area") },		//area
	case 1010:
		data->SetData(ptrMeasureData->area);
		break;
	//{ 1011, _T("width") },	//width
	case 1011:
		data->SetData(ptrMeasureData->width);
		break;
	//{ 1012, _T("height") },	//height
	case 1012:
		data->SetData(ptrMeasureData->height);
		break;
	//{ 1013, _T("center_x") },	//center_x
	case 1013:
		data->SetData(ptrMeasureData->center_x);
		break;
	//{ 1014, _T("center_y") },	//center_y
	case 1014:
		data->SetData(ptrMeasureData->center_y);
		break;

	default:
		ret = -1;
	}

	return(ret);
}

// ***************************************************************************
// title         : get processing unit data by number
// function name : int GetUnitData(ptrProcUnit, dataIdent, data)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
//				   TCHAR    *dataIdent;		Data identification name
//				   ANYTYPE  *data;			Getting data
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::GetUnitData(ProcUnit *ptrProcUnit, TCHAR *dataIdent, ANYTYPE *data)
{
	int ret = -1;

	////some internal FH-AP system param slowing us down on SetupWindow open ffs
	//if (_tcsicmp(dataIdent, _T("uiIdent")) == 0) {
	//	return ret;
	//}

	for (int i = 0; unitParam[i].no != -1; ++i) {
		if (_tcsicmp(dataIdent, unitParam[i].name) == 0) {
			ret = this->GetUnitData(ptrProcUnit, unitParam[i].no, data);
			break;
		}
	}

	return(ret);
}

