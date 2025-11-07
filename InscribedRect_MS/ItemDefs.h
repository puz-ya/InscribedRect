// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : ItemDefs.h
// Description : Definition of procitem
// ***************************************************************************

// *************************************
//         include files
// *************************************

#pragma once

//#include <opencv2/opencv.hpp>	//we don't need ALL modules
#include "opencv2/core.hpp"
#include "opencv2/imgproc.hpp"

#include <vector>
#include <tchar.h>

#include "Common/AP1CommonConstStruct.h"
#include "Common/AP1CommonFunc.h"

#include "Common/UnitInscribedRectConstStruct.h"

//using namespace cv;	//not here

// *************************************
//         macro definition
// *************************************

// definition of ProcItem class

#define	CLASSNAME	InheritedProcItem

class CLASSNAME : public ProcItem {
public:
	CLASSNAME(void);
	~CLASSNAME(void);

	virtual int		AssignProc(ProcUnit *ptrProcUnit);
	virtual int		AssignProc2(ProcUnit* ptrProcUnit);

	virtual int		DeleteProc(ProcUnit *ptrProcUnit);
	virtual int		CopyProc(ProcUnit *ptrProcUnit, ProcUnit *ptrSrcProcUnit);
	virtual int		MeasureInit(ProcUnit *ptrProcUnit);
	virtual int		MeasureEnd(ProcUnit *ptrProcUnit);
	virtual int		MeasureProc(ProcUnit *ptrProcUnit);
	virtual int		MeasureOut(ProcUnit *ptrProcUnit);
	virtual int		MeasureDispI(ProcUnit *ptrProcUnit, int subNo, ImageWindow *ptrImageWindow);
	virtual int		MeasureDispG(ProcUnit *ptrProcUnit, int subNo, ImageWindow *ptrImageWindow);
	virtual int		MeasureDispT(ProcUnit *ptrProcUnit, int subNo, TextWindow *ptrTextWindow);
	virtual int		ThroughProc(ProcUnit *ptrProcUnit);
	virtual int		RenumProc(ProcUnit *ptrProcUnit, RenumInfo *ptrRenumInfo);
	virtual int		SaveProc(ProcUnit *ptrProcUnit, SaveInfo *ptrSaveInfo);
	virtual int		LoadProc(ProcUnit *ptrProcUnit, LoadInfo *ptrLoadInfo);
	virtual int		LoadSetupData(ProcUnit *ptrProcUnit, void *loadAddress, int loadSize);
	virtual int		SetupDisp(ProcUnit *ptrProcUnit, int subNo, ImageWindow *ptrImageWindow);
	virtual int		FigureUpdate(ProcUnit *ptrProcUnit, int figureNo);
	virtual int		SetUnitData(ProcUnit *ptrProcUnit, int dataNo, ANYTYPE *data);
	virtual int		SetUnitData(ProcUnit *ptrProcUnit, TCHAR *dataIdent, ANYTYPE *data);
	virtual int		GetUnitData(ProcUnit *ptrProcUnit, int dataNo, ANYTYPE *data);
	virtual int		GetUnitData(ProcUnit *ptrProcUnit, TCHAR *dataIdent, ANYTYPE *data);
	virtual int		SetFigureType(ProcUnit *ptrProcUnit, int figureNo, int type);
	virtual int		GetFigureType(ProcUnit *ptrProcUnit, int figureNo);
	virtual int		SetFigureData(ProcUnit *ptrProcUnit, int figureNo, FIG_HEADER *figure);
	virtual int		AddFigureData(ProcUnit *ptrProcUnit, int figureNo, FIG_TYPE *type, void *data);
	virtual FIG_HEADER	*GetFigureData(ProcUnit *ptrProcUnit, int figureNo);
	virtual int		TransformXY(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcX, double srcY, double *destX, double *destY);
	virtual int		TransformAngle(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcAngle, double *destAngle);
	virtual int		TransformArea(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcArea, double *destArea);
	virtual int		TransformDist(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcDist, double *destDist);
	virtual int		TransformLine(ProcUnit *ptrProcUnit, int imageNo, int mode, double srcA, double srcB, double srcC, double *destA, double *destB, double *destC);

	int MeasureProcSub(ProcUnit *ptrProcUnit);

	//User defined methods
	void MeasureMode00(ProcUnit* ptrProcUnit, IMAGE* ptrInImage);	//verticles + mask, very long
	void MeasureMode01(ProcUnit* ptrProcUnit, IMAGE* ptrInImage);	//nonconvex poly
	void MeasureMode02(ProcUnit* ptrProcUnit, IMAGE* ptrInImage);	//pavel-gpt with rotation rect & scale

	//Slices
	std::vector<cv::Point> linePoints(int x0, int y0, int x1, int y1);
	std::vector<cv::Point> linePointsSlice(ProcUnit* ptrProcUnit, int x0, int y0, int x1, int y1);
	std::vector<cv::Point> linePointsSlice(int x0, int y0, int x1, int y1, int sliceDist, int sliceType);

};

cv::RotatedRect largestRectInNonConvexPoly(const cv::Mat1b& src, int max_angle);
cv::RotatedRect largestRectInNonConvexPoly(const cv::Mat1b& src, int max_angle, int skip_x, int skip_y);
cv::RotatedRect largestRectInNonConvexPoly(const cv::Mat1b& src, SETUPDATA* ptrSetupData);

cv::Rect findMinRect(const cv::Mat1b& src);
cv::Rect findMinRectUnoBased(const cv::Mat1b& src);
cv::Rect findMinRectUnoBased(const cv::Mat1b& src, int skip_x, int skip_y);
cv::Rect findMinRectUnoBased(const cv::Mat1b& src, SETUPDATA* ptrSetupData);

bool isRectangleInsideMask(const cv::Mat& mask, const cv::RotatedRect& rect);

// definitaion of setting data
struct SETUPDATA {
	
	int overallJudge; //Reflect to overall judgement [0 - ON, 1 - OFF]

	int unitPos1; //position of first Scan Edge unit
	int unitPos2;
	int unitPos3;
	int unitPos4;

	int mode;	//number of algo we're using
	int max_angle;	//max rotation angle to check all rect (0 to angle)

	int mode01_skip_x;	//step to skip pixels by OX when checking rectangles, did not work
	int mode01_skip_y;	//step to skip pixels by OY when checking rectangles, did not work
	int mode01_skip_h;	//step to skip calculation of H area values...mmm meh
	int mode01_skip_angle;	//step to skip angles

	int mode02_skip_angle;	//step to skip angles
	double mode02_step_scale;	//[0.01; 0.99] range

	//Slices
	int sliceEnabled;
	int sliceType;
	int sliceRows;
	int sliceCols;
	int sliceHeight;
	int sliceWidth;
	
};

// definition of mesaure data
struct MEASUREDATA {
	
	int rect_x1;	//top-left X
	int rect_y1;	//top-left Y

	int rect_x2;	//bottom-right X
	int rect_y2;	//bottom-right Y

	int width;
	int height;

	int area;		//in px*px
	int center_x;
	int center_y;

	double elapsedTime;

	std::vector<cv::Point> contour;
	cv::Point2f vert[4];	//verticles of the Main Rectangle

	//Slices
	std::vector<cv::Point> pointsOfSliceLeft;	//only selected points
	std::vector<cv::Point> pointsOfSliceTop;	//only selected points
	std::vector<cv::Point> pointsOfSliceRight;	//only selected points
	std::vector<cv::Point> pointsOfSliceBottom;	//only selected points
};

