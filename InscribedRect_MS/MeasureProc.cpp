// ***************************************************************************
//					(C) Copyright OMRON CORPORATION 2005-2011
//							All Rights Reserved
// ---------------------------------------------------------------------------
//							Procitem for FZ Series
// ***************************************************************************
// Filename    : MeasureProc.cpp
// Description : Measurement procedure
// ***************************************************************************

// *************************************
//         include files
// *************************************
#pragma once

#include	"StdAfx.h"
#include	<FZ-Include.h>
#include	"ItemDefs.h"

#include <iostream>
#include <chrono>
#include <time.h>
#include <thread>

using namespace cv;
using namespace std;
using namespace std::chrono;

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
// title         : Measurement procedure
// function name : int MeasureProc(ptrProcUnit)
// parameters    : ProcUnit *ptrProcUnit;	Pointer to processing unit
// return value  : Error code
//					NORMAL(0) : exit normally
//					else      : error exit
// ***************************************************************************

int CLASSNAME::MeasureProc(ProcUnit *ptrProcUnit)
{

	//start measuring unit working time
	steady_clock::time_point begin, end;
	steady_clock::time_point beginLic, endLic;
	begin = steady_clock::now();

	SETUPDATA	*ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA	*ptrMeasureData = ptrProcUnit->GetMeasureData();

	//reflect to overall judgement
	//reversed value of "overallJudge"
	int reflectToOverall = (ptrSetupData->overallJudge == 0) ? 1 : 0; //0 - ON, 1 - OFF

	// Filter processing execution
	int ret = MeasureProcSub(ptrProcUnit);

	if (ret != NORMAL) {
		if (ret == -3) {
			ptrProcUnit->SetUnitJudge(JUDGE_IMAGEERROR, reflectToOverall);
		}
		else if (ret == -2) {
			ptrProcUnit->SetUnitJudge(JUDGE_MEMORYERROR, reflectToOverall);
		}
		else {
			ptrProcUnit->SetUnitJudge(JUDGE_NG, reflectToOverall);
		}
		end = steady_clock::now();
		ptrMeasureData->elapsedTime = (double)duration_cast<milliseconds>(end - begin).count();
		//ptrMeasureData->elapsedTimeLic = (double)duration_cast<milliseconds>(endLic - beginLic).count();
		return NORMAL;
	}
	else {
		ptrProcUnit->SetUnitJudge(JUDGE_OK, reflectToOverall);
	}

	end = steady_clock::now();
	ptrMeasureData->elapsedTime = (double)duration_cast<milliseconds>(end - begin).count();
	//ptrMeasureData->elapsedTimeLic = (double)duration_cast<milliseconds>(endLic - beginLic).count();

	return NORMAL;
}

int CLASSNAME::MeasureProcSub(ProcUnit *ptrProcUnit)
{
	//start measuring unit working time
	steady_clock::time_point begin, end;
	
	SETUPDATA	*ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA *ptrMeasureData = ptrProcUnit->GetMeasureData();

	IMAGE *ptrInImage = ptrProcUnit->GetMeasureImage(0);
	if (ptrInImage == NULL) {
		return(-2);
	}
	if (ptrInImage->sizeX == 0 || ptrInImage->sizeY == 0) {
		return -2;
	}

	ptrProcUnit->ImageDataAlloc(0, sizeof(IMAGE) + ptrInImage->size);
	IMAGE *ptrOutImage = ptrProcUnit->GetImageData(0);
	if (NULL == ptrOutImage) {
		return(-2);
	}

	ptrMeasureData->pointsOfSliceLeft.clear();
	ptrMeasureData->pointsOfSliceTop.clear();
	ptrMeasureData->pointsOfSliceRight.clear();
	ptrMeasureData->pointsOfSliceBottom.clear();

	int sizeX = ptrInImage->sizeX;
	int sizeY = ptrInImage->sizeY;
	
	//TODO: only Mode01 works fast enough to consider using
	//ptrSetupData->mode = 2;

	RotatedRect best;

	switch(ptrSetupData->mode + 1) {
		case -1000:
			//Very long Point-based method, 20 sec (!) on 640x480, just to tests
			MeasureMode00(ptrProcUnit, ptrInImage);
		break;

		case 1:
			//Non Convex Poly method
			MeasureMode01(ptrProcUnit, ptrInImage);
		break;

		case 2:
			//Convex Pavel-GPT method
			MeasureMode02(ptrProcUnit, ptrInImage);

		default:
			MeasureMode01(ptrProcUnit, ptrInImage);
	}	

	if (ptrSetupData->sliceEnabled == 1) {

		//The order of points is bottomLeft, topLeft, topRight, bottomRight.
		if (ptrSetupData->sliceType == SLICE_ROWS_COLS) {

			if (ptrSetupData->sliceRows > SIZE1024) {
				ptrSetupData->sliceRows = SIZE1024;
			}
			if (ptrSetupData->sliceRows < 1) {
				ptrSetupData->sliceRows = 1;
			}
			if (ptrSetupData->sliceCols > SIZE1024) {
				ptrSetupData->sliceCols = SIZE1024;
			}
			if (ptrSetupData->sliceCols < 1) {
				ptrSetupData->sliceCols = 1;
			}

			ptrSetupData->sliceHeight = ptrMeasureData->height / ptrSetupData->sliceRows;

			//check height of the slice
			if (ptrSetupData->sliceHeight < MIN_SLICE_HEIGHT) {
				ptrSetupData->sliceHeight = MIN_SLICE_HEIGHT;
				//recalc number of Columns back
				ptrSetupData->sliceRows = ptrMeasureData->height / ptrSetupData->sliceHeight;

			}
			/*
			if (ptrMeasureData->height % ptrSetupData->sliceHeight != 0) {

				//if we have some modulus -> increase number of Rows/Cols by 1 (last smaller part till vertex)
				ptrSetupData->sliceRows++;
			}
			//*/

			ptrSetupData->sliceWidth = ptrMeasureData->width / ptrSetupData->sliceCols;
			//check width of the slice
			if (ptrSetupData->sliceWidth < MIN_SLICE_WIDTH) {
				ptrSetupData->sliceWidth = MIN_SLICE_WIDTH;
				//recalc number of Columns back
				ptrSetupData->sliceCols = ptrMeasureData->width / ptrSetupData->sliceWidth;

			}
			/*
			if (ptrMeasureData->width % ptrSetupData->sliceWidth != 0) {
				ptrSetupData->sliceCols++;
			}
			//*/

		}
		else if (ptrSetupData->sliceType == SLICE_HEIGHT_WIDTH){

			if (ptrSetupData->sliceHeight > MAX_OY - 1) {
				ptrSetupData->sliceHeight = MAX_OY - 1;
			}
			if (ptrSetupData->sliceHeight < MIN_SLICE_HEIGHT) {
				ptrSetupData->sliceHeight = MIN_SLICE_HEIGHT;
			}
			if (ptrSetupData->sliceWidth > MAX_OX - 1) {
				ptrSetupData->sliceWidth = MAX_OX - 1;
			}
			if (ptrSetupData->sliceWidth < MIN_SLICE_WIDTH) {
				ptrSetupData->sliceWidth = MIN_SLICE_WIDTH;
			}

			ptrSetupData->sliceRows = ptrMeasureData->height / ptrSetupData->sliceHeight;

			
			if (ptrMeasureData->height / ptrSetupData->sliceHeight == 0) {

				//if Main Rect height << user's sliceHeight -> reset sliceRows & sliceHeight
				ptrSetupData->sliceRows = 1;
				ptrSetupData->sliceHeight = ptrMeasureData->height;

			}
			if (ptrMeasureData->height % ptrSetupData->sliceHeight != 0) {

				//if we have some modulus -> increase number of Rows/Cols by 1 (last smaller part till vertex)
				ptrSetupData->sliceRows++;
			}

			ptrSetupData->sliceCols = ptrMeasureData->width / ptrSetupData->sliceWidth;

			if (ptrMeasureData->width / ptrSetupData->sliceWidth == 0) {
				ptrSetupData->sliceCols = 1;
				ptrSetupData->sliceWidth = ptrMeasureData->width;
			}
			if (ptrMeasureData->width % ptrSetupData->sliceWidth != 0) {
				ptrSetupData->sliceCols++;
			}

		}

		//Check left & right sides of rectangle (parallel)
			/*
			double mLeft = 0.0; //inclanation
			if (x[0] != x[1]) {
				mLeft = (x[0] - x[1]) / (y[0] - y[1]);
			}
			double mRight = 0.0; //inclanation
			if (x[2] != x[3]) {
				mRight = (x[2] - x[3]) / (y[2] - y[3]);
			}
			//*/

		ptrMeasureData->pointsOfSliceLeft = linePointsSlice(
			ptrMeasureData->vert[0].x, ptrMeasureData->vert[0].y,
			ptrMeasureData->vert[1].x, ptrMeasureData->vert[1].y,
			ptrSetupData->sliceHeight, ptrSetupData->sliceType);

		ptrMeasureData->pointsOfSliceTop = linePointsSlice(
			ptrMeasureData->vert[1].x, ptrMeasureData->vert[1].y,
			ptrMeasureData->vert[2].x, ptrMeasureData->vert[2].y,
			ptrSetupData->sliceWidth, ptrSetupData->sliceType);

		ptrMeasureData->pointsOfSliceRight = linePointsSlice(
			ptrMeasureData->vert[3].x, ptrMeasureData->vert[3].y,
			ptrMeasureData->vert[2].x, ptrMeasureData->vert[2].y,
			ptrSetupData->sliceHeight, ptrSetupData->sliceType);

		ptrMeasureData->pointsOfSliceBottom = linePointsSlice(
			ptrMeasureData->vert[0].x, ptrMeasureData->vert[0].y,
			ptrMeasureData->vert[3].x, ptrMeasureData->vert[3].y,
			ptrSetupData->sliceWidth, ptrSetupData->sliceType);

		//SliceEnabled End

	}

	//ptrProcUnit->SetMeasureImage(0, 0);

	return NORMAL;
}

vector<cv::Point> CLASSNAME::linePoints(int x0, int y0, int x1, int y1)
{
	vector<Point> pointsOfLine;

	int dx = abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
	int dy = abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
	int err = (dx > dy ? dx : -dy) / 2, e2;

	for (;;)
	{
		pointsOfLine.push_back(Point(x0, y0));
		if (x0 == x1 && y0 == y1) break;
		e2 = err;
		if (e2 > -dx)
		{
			err -= dy;
			x0 += sx;
		}
		if (e2 < dy)
		{
			err += dx;
			y0 += sy;
		}
	}
	return pointsOfLine;
}

vector<cv::Point> CLASSNAME::linePointsSlice(int x0, int y0, int x1, int y1, int sliceDist, int sliceType)
{
	//SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	//MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

	vector<Point> pointsOfLine;
	vector<Point> pointsOfLineSlice;	//only selected points

	int dx = abs(x1 - x0), sx = x0 < x1 ? 1 : -1;
	int dy = abs(y1 - y0), sy = y0 < y1 ? 1 : -1;
	int err = (dx > dy ? dx : -dy) / 2, e2;

	int xSlice = x0, ySlice = y0;

	//move x0, y0 along the line
	//xSlice, ySlice will follow

	for (;;)
	{
		pointsOfLine.push_back(Point(x0, y0));

		if (abs(Dist(x0, xSlice, y0, ySlice) - sliceDist) < 1) {
			pointsOfLineSlice.push_back(Point(xSlice, ySlice));
			xSlice = x0;
			ySlice = y0;
		}

		if (x0 == x1 && y0 == y1) {
			if ((xSlice != x0 || ySlice != y0) && (sliceType != SLICE_ROWS_COLS)) {
				//keep one previous point (distance was not enough)
				pointsOfLineSlice.push_back(Point(xSlice, ySlice));
			}
			//keep the final point
			pointsOfLineSlice.push_back(Point(x0, y0));

			break;
		}

		e2 = err;
		if (e2 > -dx)
		{
			err -= dy;
			x0 += sx;
		}
		if (e2 < dy)
		{
			err += dx;
			y0 += sy;
		}
	}
	return pointsOfLineSlice;
}


/// <summary>
/// Mode00 just for the tests. It's too slow for any production line.
/// Playground.
/// </summary>
/// <param name="ptrProcUnit"></param>
/// <param name="ptrInImage"></param>
void CLASSNAME::MeasureMode00(ProcUnit* ptrProcUnit, IMAGE* ptrInImage) {

	//start measuring unit working time
	steady_clock::time_point begin, end;

	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

//https://stackoverflow.com/a/70365569
//NOT F WORKING
//F opencv CRASH on .at() at random WTF

//WORKING, set integral loop sizes - 1;
//Still, TOO SLOW

//Masks & Rectangle
//cv::Mat img = cv::Mat::zeros(sizeX, sizeY, CV_8UC3);

	cv::Mat img = cv::Mat::zeros(SIZE512, SIZE512, CV_8UC3);
	cv::Mat mask = cv::Mat::zeros(img.size(), CV_8UC1);

	ptrMeasureData->contour.clear();
	ptrMeasureData->contour = { cv::Point(100,100), cv::Point(150,200), cv::Point(200,160), cv::Point(220, 230), cv::Point(90,270) };

	std::vector<std::vector<cv::Point> > contours = { ptrMeasureData->contour };
	//thickness -1 will fill mask with "1,1,1" values by contours
	cv::drawContours(mask, contours, 0, cv::Scalar::all(1), -1); // mask values to 1 to make area == sum of pixels
	cv::drawContours(img, contours, 0, cv::Scalar(0, 0, 255), 1);

	cv::Mat integral;
	//cv::Mat integral = cv::Mat::zeros(img.size(), CV_8UC1);
	//mask = mask;
	cv::integral(mask, integral, CV_32S);

	cv::Rect best_local;
	for (int y = 0; y < mask.rows; ++y)
	{
		std::cout << y << std::endl;

		for (int x = 0; x < mask.cols; ++x)
		{
			if (mask.at<uchar>(y, x) == 0) continue; //original

			cv::Point i1 = cv::Point(x, y);
			int val1 = integral.at<int>(i1);

			for (int y2 = y + 1; y2 < integral.rows - 1; y2++)
			{
				for (int x2 = x + 1; x2 < integral.cols - 1; x2++)
				{
					cv::Point i2 = cv::Point(x2, y);
					cv::Point i3 = cv::Point(x, y2);
					cv::Point i4 = cv::Point(x2, y2);
					if (mask.at<uchar>(i4) == 0) continue;
					int val2 = integral.at<int>(i2);
					int val3 = integral.at<int>(i3);
					int val4 = integral.at<int>(i4);

					int area = val1 + val4 - val2 - val3;

					//if (area != (x2 - x) * (y2 - y))
					//{
					//	//DO NOT uncomment, very long even for example
					//	
					//	//std::cout << i1 << " to " << i4 << " = w:" << (x2 - x) << " h:" << (y2 - y) << std::endl;
					//	//std::cout << area << " vs. " << (x2 - x) * (y2 - y) << std::endl;
					//	//legal.at<uchar>(y, x) = 0;
					//	//std::cin.get();
					//}
					//else
					//{
					//	if (area > best_local.area()) best_local = cv::Rect(i1, i4);
					//}

					if (area == (x2 - x) * (y2 - y)) {
						if (area > best_local.area()) {
							best_local = cv::Rect(i1, i4);
						}
					}
				}
			}
		}

	}

	cv::rectangle(img, best_local, cv::Scalar(255, 0, 0), 1);

	ptrMeasureData->rect_x1 = best_local.x;
	ptrMeasureData->rect_y1 = best_local.y;
	ptrMeasureData->rect_x2 = best_local.x + best_local.width;
	ptrMeasureData->rect_y2 = best_local.y + best_local.height;

	ptrMeasureData->width = best_local.width;
	ptrMeasureData->height = best_local.height;
	ptrMeasureData->area = best_local.area();
	ptrMeasureData->center_x = best_local.x + best_local.width / 2;
	ptrMeasureData->center_y = best_local.y + best_local.height / 2;

}

void CLASSNAME::MeasureMode01(ProcUnit* ptrProcUnit, IMAGE* ptrInImage) {

	//start measuring unit working time
	steady_clock::time_point begin, end;

	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

	//https://stackoverflow.com/a/32682512
	//Mat1b img = imread("path_to_image", IMREAD_GRAYSCALE);
	//MONO images only!
	Mat img = Mat(ptrInImage->sizeY, ptrInImage->sizeX, CV_8U, ptrInImage->imageData);

	//replace all "1" black values with OpenCV "0"
	//https://stackoverflow.com/a/32348783
	int newValue = 0;
	int oldValue = 1;
	img.setTo(newValue, img == oldValue);

	begin = steady_clock::now();

	// Compute largest rect inside polygon
	RotatedRect retRect = largestRectInNonConvexPoly(img, ptrSetupData);

	end = steady_clock::now();
	cout << "largestRectInNonConvexPoly(img)" << (double)duration_cast<milliseconds>(end - begin).count() << endl;

	// Store 4 vertices of the rectangle
	for (int i = 0; i < 4; i++) {
		ptrMeasureData->vert[i] = Point2f(0.f, 0.f);
	}

	// The order is bottomLeft, topLeft, topRight, bottomRight.
	retRect.points(ptrMeasureData->vert);

	ptrMeasureData->width = retRect.size.width;
	ptrMeasureData->height = retRect.size.height;
	ptrMeasureData->area = retRect.size.area();
	ptrMeasureData->center_x = retRect.center.x;
	ptrMeasureData->center_y = retRect.center.y;

}

// Find all "0", skip others
// https://stackoverflow.com/a/30418912/5008845
Rect findMinRect(const Mat1b& src)
{
	Mat1f W(src.rows, src.cols, float(0));
	Mat1f H(src.rows, src.cols, float(0));

	Rect maxRect(0, 0, 0, 0);
	float maxArea = 0.f;

	for (int r = 0; r < src.rows; ++r)
	{
		for (int c = 0; c < src.cols; ++c)
		{
			if (src(r, c) == 0)
			{
				H(r, c) = 1.f + ((r > 0) ? H(r - 1, c) : 0);
				W(r, c) = 1.f + ((c > 0) ? W(r, c - 1) : 0);
			}

			float minw = W(r, c);
			for (int h = 0; h < H(r, c); ++h)
			{
				minw = min(minw, W(r - h, c));
				float area = (h + 1) * minw;
				if (area > maxArea)
				{
					maxArea = area;
					maxRect = Rect(Point(c - minw + 1, r - h), Point(c + 1, r + 1));
				}
			}
		}
	}

	return maxRect;
}

// Finding all "255", not zeros as in findMinRect
// Based on: https://stackoverflow.com/a/30418912/5008845
Rect findMinRectUnoBased(const Mat1b& src, SETUPDATA* ptrSetupData)
{
	//start measuring unit working time
	steady_clock::time_point begin, end;
	
	begin = steady_clock::now();

	Mat1f W(src.rows, src.cols, float(0));
	Mat1f H(src.rows, src.cols, float(0));

	Rect maxRect(0, 0, 0, 0);
	float maxArea = 0.f;

	for (int r = 0; r < src.rows; r += 1)
	{
		for (int c = 0; c < src.cols; c += 1)
		{
			if (src(r, c) == 255)
			{
				H(r, c) = 1.f + ((r > 0) ? H(r - 1, c) : 0);
				W(r, c) = 1.f + ((c > 0) ? W(r, c - 1) : 0);
			}

			float minw = W(r, c);
			int maxH = H(r, c);

			for (int h = 0; h < maxH; h += 1)
			{
				minw = min(minw, W(r - h, c));
				float area = (h + 1) * minw;
				if (area > maxArea)
				{
					maxArea = area;
					maxRect = Rect(Point(c - minw + 1, r - h), Point(c + 1, r + 1));
				}
			}
		}
	}

	end = steady_clock::now();
	cout << "findMinRectUnoBased(): " << (double)duration_cast<milliseconds>(end - begin).count() << endl;

	return maxRect;
}

RotatedRect largestRectInNonConvexPoly(const Mat1b& src, SETUPDATA* ptrSetupData)
{

	//start measuring unit working time
	steady_clock::time_point begin, end;

	steady_clock::time_point begin_p1, end_p1;
	begin_p1 = steady_clock::now();

	if (ptrSetupData->max_angle < 0 || ptrSetupData->max_angle > 90) {
		Point2f emptyP1 = Point2f(0, 0);
		Point2f emptyP2 = Point2f(0, 1);
		Point2f emptyP3 = Point2f(1, 1);
		return RotatedRect(emptyP1, emptyP2, emptyP3);
	}

	// Create a matrix big enough to not lose points during rotation

	//TODO: trying to disable findNonZero(), we have 0 & 255 values only 
	//vector<Point> ptz;
	//findNonZero(src, ptz);
	//Rect bbox = boundingRect(ptz);
	
	Rect bbox = boundingRect(src);
	int maxdim = max(bbox.width, bbox.height);
	Mat1b work(2 * maxdim, 2 * maxdim, uchar(0));
	src(bbox).copyTo(work(Rect(maxdim - bbox.width / 2, maxdim - bbox.height / 2, bbox.width, bbox.height)));

	end_p1 = steady_clock::now();
	cout << "largestRectInNonConvexPoly() Part1: " << (double)duration_cast<milliseconds>(end_p1 - begin_p1).count() << endl;

	// Store best data
	Rect bestRect = Rect(0,0,1,1);
	int bestAngle = 0;

	steady_clock::time_point begin_p2, end_p2;

	// For each angle
	for (int angle = -ptrSetupData->max_angle; angle <= ptrSetupData->max_angle; angle += 1 + ptrSetupData->mode01_skip_angle)
	{
		cout << angle << endl;
		begin_p2 = steady_clock::now();

		// Rotate the image
		Mat R = getRotationMatrix2D(Point(maxdim, maxdim), angle, 1);
		Mat1b rotated;
		warpAffine(work, rotated, R, work.size());

		// Keep the crop with the polygon
		
		//TODO: trying to disable findNonZero(), we have 0 & 255 values only 
		//vector<Point> pts;
		//findNonZero(rotated, pts);
		//Rect box = boundingRect(pts);
		
		Rect box = boundingRect(rotated);
		Mat1b crop = rotated(box).clone();

		//try this, no invert.
		// https://stackoverflow.com/questions/2478447/find-largest-rectangle-containing-only-zeros-in-an-n%C3%97n-binary-matrix
		Rect r = findMinRectUnoBased(crop, ptrSetupData);

		//// Invert colors
		//crop = ~crop;

		//// Solve the problem: "Find largest rectangle containing only zeros in an binary matrix"
		//// https://stackoverflow.com/questions/2478447/find-largest-rectangle-containing-only-zeros-in-an-n%C3%97n-binary-matrix
		//Rect r = findMinRect(crop);
		//

		// If best, save result
		if (r.area() > bestRect.area())
		{
			bestRect = r + box.tl();    // Correct the crop displacement
			bestAngle = angle;
		}

		end_p2 = steady_clock::now();
		cout << "largestRectInNonConvexPoly() Part2 Center: " << (double)duration_cast<milliseconds>(end_p2 - begin_p2).count() << endl;
	}

	steady_clock::time_point begin_p3, end_p3;
	begin_p3 = steady_clock::now();

	// Apply the inverse rotation
	Mat Rinv = getRotationMatrix2D(Point(maxdim, maxdim), -bestAngle, 1);
	vector<Point> rectPoints{ bestRect.tl(), Point(bestRect.x + bestRect.width, bestRect.y), bestRect.br(), Point(bestRect.x, bestRect.y + bestRect.height) };
	vector<Point> rotatedRectPoints;
	transform(rectPoints, rotatedRectPoints, Rinv);

	// Apply the reverse translations
	for (int i = 0; i < rotatedRectPoints.size(); ++i)
	{
		rotatedRectPoints[i] += bbox.tl() - Point(maxdim - bbox.width / 2, maxdim - bbox.height / 2);
	}

	// Get the rotated rect
	RotatedRect rrect = minAreaRect(rotatedRectPoints);

	end_p3 = steady_clock::now();
	cout << "largestRectInNonConvexPoly() Part3 End: " << (double)duration_cast<milliseconds>(end_p3 - begin_p3).count() << endl;

	return rrect;
}

// Check if Rect in Mask 
bool isRectangleInsideMask(const Mat& mask, const RotatedRect& rect) {
	
	Point2f rectPoints[4];
	rect.points(rectPoints);
	uchar mask_val;

	for (int i = 0; i < 4; i++) {
		
		//first check boundaries, because of rect rotation -> out of MASK borders!
		if (rectPoints[i].x < 0 || rectPoints[i].x >= mask.cols ||
			rectPoints[i].y < 0 || rectPoints[i].y >= mask.rows) {
			
			return false;
		}
		else {
			//if we're inside the MASK borders, check MASK pixels
			mask_val = mask.at<uchar>(rectPoints[i].y, rectPoints[i].x);
			
			if (mask_val == 0) {
				return false;
			}
		}

	}
	return true;
}

//Pavel-GPT Method with scaling and rotating the rectangle
void CLASSNAME::MeasureMode02(ProcUnit* ptrProcUnit, IMAGE* ptrInImage) {

	//start measuring unit working time
	steady_clock::time_point begin, end;
	begin = steady_clock::now();

	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

	Mat binary = Mat(ptrInImage->sizeY, ptrInImage->sizeX, CV_8U, ptrInImage->imageData);
	
	//replace all "1" black values with OpenCV "0"
	//https://stackoverflow.com/a/32348783
	int newValue = 0;
	int oldValue = 1;
	binary.setTo(newValue, binary == oldValue);

	// Find contours
	vector<vector<Point>> contours;
	findContours(binary, contours, RETR_EXTERNAL, CHAIN_APPROX_SIMPLE);
	
	// Find biggest contour
	int largestContourIdx = -1;
	double maxArea = 0;
	for (size_t i = 0; i < contours.size(); i++) {
		double area = contourArea(contours[i]);
		if (area > maxArea) {
			maxArea = area;
			largestContourIdx = i;
		}
	}

	if (largestContourIdx == -1) {
		cout << "NO contours" << endl;
		return;
	}

	// Create object mask
	Mat mask = Mat::zeros(binary.size(), CV_8UC1);
	drawContours(mask, contours, largestContourIdx, Scalar(255), FILLED);

	// Search for max inscribbed rectangle
	RotatedRect bestRect;
	double bestArea = 0;

	// Iterations per all possible rotation angles and sizes of rectangle
	for (int angle = -ptrSetupData->max_angle; angle <= ptrSetupData->max_angle; angle += 1 + ptrSetupData->mode02_skip_angle) {  // Rotations -180;180
		for (float scale = 1.0; scale > 0.1; scale -= ptrSetupData->mode02_step_scale) {  // Changing scale
			RotatedRect rect = RotatedRect(
				Point2f(mask.cols / 2.0f, mask.rows / 2.0f), 
				Size2f(mask.cols * scale, mask.rows * scale), 
				angle
			);
			
			if (isRectangleInsideMask(mask, rect)) {
				double area = rect.size.width * rect.size.height;
				if (area > bestArea) {
					bestArea = area;
					bestRect = rect;
				}

				break;	//if we've found an OK area for this iteration, no point in making it LESS by next scale.
			}
		}
	}

	// Store 4 vertices of the rectangle
	for (int i = 0; i < 4; i++) {
		ptrMeasureData->vert[i] = Point2f(0.f, 0.f);
	}

	//The order is bottomLeft, topLeft, topRight, bottomRight.
	bestRect.points(ptrMeasureData->vert);

	ptrMeasureData->width = bestRect.size.width;
	ptrMeasureData->height = bestRect.size.height;
	ptrMeasureData->area = bestRect.size.area();
	ptrMeasureData->center_x = bestRect.center.x;
	ptrMeasureData->center_y = bestRect.center.y;

	end = steady_clock::now();

}
