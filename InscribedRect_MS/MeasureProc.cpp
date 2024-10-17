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
	ptrProcUnit->ImageDataAlloc(0, sizeof(IMAGE) + ptrInImage->size);
	IMAGE *ptrOutImage = ptrProcUnit->GetImageData(0);
	if (NULL == ptrOutImage) {
		return(-2);
	}

	//copy only Image Data headers
	//memcpy(ptrOutImage, ptrInImage, sizeof(IMAGE));


	int	judge = JUDGE_OK;

	int sizeX = ptrInImage->sizeX;
	int sizeY = ptrInImage->sizeY;
	
	//TODO: only Mode01 works fast enough to consider using
	ptrSetupData->mode = 1;

	RotatedRect best;

	switch(ptrSetupData->mode) {
		case 0:
			//Very long Point-basde method, 20 sec (!) on 640x480, just to tests
			MeasureMode00(ptrProcUnit, ptrInImage);
		break;

		case 1:
			//Non Convex Poly method
			MeasureMode01(ptrProcUnit, ptrInImage);
		break;

		default:
			MeasureMode01(ptrProcUnit, ptrInImage);
	}	

	//ptrProcUnit->SetMeasureImage(0, 0);

	return NORMAL;
}

void CLASSNAME::MeasureMode00(ProcUnit* ptrProcUnit, IMAGE* ptrInImage) {

	//start measuring unit working time
	steady_clock::time_point begin, end;

	SETUPDATA* ptrSetupData = ptrProcUnit->GetSetupData();
	MEASUREDATA* ptrMeasureData = ptrProcUnit->GetMeasureData();

	//if (ptrSetupData->unitPos1 == 0 && ptrSetupData->unitPos2 == 0 && ptrSetupData->unitPos3 == 0 && ptrSetupData->unitPos4 == 0) {
	//	return -2;
	//}

	//ANYTYPE* data1 = new ANYTYPE();
	//ANYTYPE* data2 = new ANYTYPE();
	//ANYTYPE* data3 = new ANYTYPE();
	//ANYTYPE* data4 = new ANYTYPE();

	//ProcUnit* pUnit1 = ptrProcUnit->GetProcUnit(ptrSetupData->unitPos1);
	//ProcUnit* pUnit2 = ptrProcUnit->GetProcUnit(ptrSetupData->unitPos2);
	//ProcUnit* pUnit3 = ptrProcUnit->GetProcUnit(ptrSetupData->unitPos3);
	//ProcUnit* pUnit4 = ptrProcUnit->GetProcUnit(ptrSetupData->unitPos4);

	////std::vector<int> anypos = { ptrSetupData->unitPos1, ptrSetupData->unitPos2, ptrSetupData->unitPos3, ptrSetupData->unitPos4 };
	//std::vector<ProcUnit*> anyProc;
	//std::vector<ANYTYPE*> anyTypes;

	////162 for Scan edge pos == scanLines (number of scan regions)
	//if (pUnit1 != nullptr) {
	//	//GetUnitData(pUnit1, 162, data1);
	//	pUnit1->GetUnitData(162, data1);

	//	anyProc.push_back(pUnit1);
	//	anyTypes.push_back(data1);
	//}
	//else {
	//	return -2;
	//}

	//if (pUnit2 != nullptr) {
	//	//GetUnitData(pUnit2, 162, data2);
	//	pUnit2->GetUnitData(162, data2);

	//	anyProc.push_back(pUnit2);
	//	anyTypes.push_back(data2);
	//}
	//else {
	//	return -2;
	//}

	//if (pUnit3 != nullptr) {
	//	pUnit3->GetUnitData(162, data3);

	//	anyProc.push_back(pUnit3);
	//	anyTypes.push_back(data3);
	//}
	//else {
	//	return -2;
	//}

	//if (pUnit4 != nullptr) {
	//	pUnit4->GetUnitData(162, data4);

	//	anyProc.push_back(pUnit4);
	//	anyTypes.push_back(data4);
	//}
	//else {
	//	return -2;
	//}



	//int k = 0;
	////Initialize std::vector from MeasureData struct.
	//ptrMeasureData->contour = std::vector<cv::Point>();
	//ptrMeasureData->contour.clear();

	////Collecting all points from all 4 possible scan edge pos units
	//for (ANYTYPE* type : anyTypes) {
	//	int lineLimit = type->GetIntValue();

	//	lineLimit = 10;

	//	int x, y;
	//	ANYTYPE* data = new ANYTYPE();

	//	//cv::Point cvp(0, 0);

	//	for (int i = 0; i < lineLimit; i++) {

	//		anyProc[k]->GetUnitData(30000 + i, data);
	//		x = data->GetIntValue();
	//		anyProc[k]->GetUnitData(40000 + i, data);
	//		y = data->GetIntValue();

	//		//if (cvp.x != 0 && cvp.y != 0) {
	//		if (x != 0 && y != 0) {
	//			//ptrMeasureData->contour.push_back(cv::Point(x,y));
	//			ptrMeasureData->contour.push_back(cv::Point(x, y));
	//		}

	//	}

	//	k++;
	//	delete data;
	//}


//https://stackoverflow.com/a/70365569
//NOT F WORKING
//F opencv CRASH on .at() at random WTF

//WORKING, set integral loop sizes - 1;
//Still, TOO SLOW

//Masks & Rectangle
//cv::Mat img = cv::Mat::zeros(sizeX, sizeY, CV_8UC3);

	cv::Mat img = cv::Mat::zeros(512, 512, CV_8UC3);
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
			//if (mask.at<uchar>(x, y) == 0) continue;

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


	//delete data1;
	//delete data2;
	//delete data3;
	//delete data4;


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
	RotatedRect r = largestRectInNonConvexPoly(img, ptrSetupData->angle);

	end = steady_clock::now();
	cout << "largestRectInNonConvexPoly(img)" << (double)duration_cast<milliseconds>(end - begin).count() << endl;

	/** returns 4 vertices of the rectangle
	@param pts The points array for storing rectangle vertices. The order is bottomLeft, topLeft, topRight, bottomRight.
	*/
	//Point2f pts[4];
	for (int i = 0; i < 4; i++) {
		ptrMeasureData->vert[i] = Point2f(0.f, 0.f);
	}
	//r.points(pts);
	r.points(ptrMeasureData->vert);

	ptrMeasureData->width = r.size.width;
	ptrMeasureData->height = r.size.height;
	ptrMeasureData->area = r.size.area();
	ptrMeasureData->center_x = r.center.x;
	ptrMeasureData->center_y = r.center.y;

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
Rect findMinRectUnoBased(const Mat1b& src)
{
	//start measuring unit working time
	steady_clock::time_point begin, end;
	
	begin = steady_clock::now();

	Mat1f W(src.rows, src.cols, float(0));
	Mat1f H(src.rows, src.cols, float(0));

	Rect maxRect(0, 0, 0, 0);
	float maxArea = 0.f;

	for (int r = 0; r < src.rows; ++r)
	{
		for (int c = 0; c < src.cols; ++c)
		{
			if (src(r, c) == 255)
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

	end = steady_clock::now();
	cout << "findMinRectUnoBased(): " << (double)duration_cast<milliseconds>(end - begin).count() << endl;

	return maxRect;
}


RotatedRect largestRectInNonConvexPoly(const Mat1b& src, int max_angle)
{

	//start measuring unit working time
	steady_clock::time_point begin, end;

	steady_clock::time_point begin_p1, end_p1;
	begin_p1 = steady_clock::now();

	if (max_angle < 0 || max_angle > 90) {
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
	for (int angle = 0; angle <= max_angle; angle += 1)
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
		Rect r = findMinRectUnoBased(crop);

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
